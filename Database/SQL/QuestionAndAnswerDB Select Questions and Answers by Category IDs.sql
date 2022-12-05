select top 500 q.Text, a.Text
from Answer a
inner join Question q on q.ID = a.QuestionID
inner join QuestionCategory qc on qc.QuestionID = q.ID
where qc.CategoryID in (6622, 6629, 6630, 6623)
order by a.ID Desc