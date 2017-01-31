store classes related to project here

*SQLDriver.cs* (adam):
username: charlesroot
password: Ieamainsuranceclaim123
SQL Server URL: insuranceclaim.database.windows.net

database schema:
table users:
firstname (nvarchar(50)) nulls - no
lastname (nvarchar(50)) nulls - yes
username (nvarchar(50)) nulls - no
password (nvarchar(MAX)) nulls - no
rank (int) nulls - no
(key) id (bigint) nulls - no

table claims:
date (nvarchar(50)) nulls - no
username (nvarchar(50)) nulls - no
claim (nvarchar(MAX)) nulls - no
(key) id (bigint) nulls - no

table messages:
to (nvarchar(50)) nulls - no
from (nvarchar(50)) nulls - no
date (nvarchar(50)) nulls - no
subject (nvarchar(50)) nulls - no
message (nvarchar(MAX)) nulls - no
(key) id (bigint) nulls - no
