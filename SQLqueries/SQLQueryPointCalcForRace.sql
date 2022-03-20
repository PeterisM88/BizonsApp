--CREATE VIEW vPointsByParticipant
--AS

-- Final results 
-- Calculates points for each participant in one race or in all races
WITH cte AS (
   SELECT * ,
            MIN(IIF(Distance_Result > 0, Distance_Result, NULL)) OVER (PARTITION BY [Age_Group], [Race_nr] ORDER BY [Distance_Result] ASC) AS Min_Distance
   FROM  [ParticipantForm]
),
  pointsByStartNum AS (
    SELECT *    
    FROM (
           SELECT * ,
                   CASE WHEN Distance_Result = 0 THEN 0
                        ELSE CAST(ROUND( [Min_Distance] * 1000.0 / [Distance_Result], 0 ) AS INT)
                   END AS Points
           FROM  cte 
    ) t
) 
SELECT [Age_group] AS 'Vecuma grupa',
       [Start_Number] AS 'Starta numurs',
       [First_Name] AS Vārds,
       [Last_Name] AS Uzvārds,
       [Distance_Result] AS Laiks,
       [Race_nr] AS Posms, -- If calculating points in multiple races
	   Points AS Punkti
FROM   pointsByStartNum 
 --WHERE [Race_nr] = 3
-- ORDER BY isn't allowed in views
  ORDER BY [Age_group], [Race_nr], Points DESC


-- DROP VIEW vPointsByParticipant

/*
SELECT * 
FROM  vPointsByParticipant
ORDER BY [Age_group], [Race_nr], Points DESC

*/ 

