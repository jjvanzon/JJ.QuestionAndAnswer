select top (@count) x.ID
from 
(
	select 
		q.ID, 
		ROW_NUMBER() over (order by q.ID) as RowNumber 
	from Question q
) as x
-- RowNumber is 1-based.
where x.RowNumber > @firstIndex
order by x.RowNumber;
