INSERT INTO IssuePatient
SELECT TOP(80) I.Id, P.Id
FROM Issues I CROSS JOIN Patients P
ORDER BY NEWID()