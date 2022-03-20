-- Query calculates final result for competition
-- Calculating sum of the points of the 5 best stages

WITH allScores AS (
   SELECT *, CASE 
                WHEN Distance_Result = 0 THEN 0
                ELSE MIN(IIF(Distance_Result > 0, Distance_Result, NULL))  OVER (PARTITION BY [Age_Group], [Race_nr] ORDER BY [Distance_Result] ASC)
                      * 1000.0 / [Distance_Result]                   
            END AS Points
   FROM  [ParticipantForm]
),
 rankedParticipantScores AS (
    SELECT * ,
            ROW_NUMBER() OVER(PARTITION BY [Age_group], [Start_Number] ORDER BY Points DESC ) AS Row_Num   
    FROM  allScores 
),
 bestParticipantScores AS (
   SELECT [Age_group],
          [Start_number],
          [First_name],
          [Last_Name],
          CAST(ROUND( SUM( Points ), 0 ) AS INT)  AS Gala_Rezultati
   FROM   rankedParticipantScores
   WHERE  Row_Num <= 5
   GROUP BY [Age_group], [Start_number], [First_name], [Last_Name]
),
 rankedWinners AS (
    SELECT * , 
			ROW_NUMBER() OVER(PARTITION BY [Age_group] ORDER BY Gala_Rezultati DESC ) AS Vieta_Grupā
    FROM  bestParticipantScores
)
SELECT [Age_group] AS 'Vecuma grupa',
	   [Start_number] AS 'Starta numurs',
	   [First_name] AS Vārds,
	   [Last_Name] AS Uzvārds,
	   Gala_Rezultati,
	   Vieta_Grupā
FROM   rankedWinners
--WHERE  Vieta_Grupā <= 3 -- Top 3 winners in group
ORDER BY Age_Group
