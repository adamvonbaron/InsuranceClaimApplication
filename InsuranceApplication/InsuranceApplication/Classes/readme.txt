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
creation (nvarchar(50)) nulls - no
claims (int) nulls - no
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

sql workflow (profile):
1. grab data from sql server and put in text fields
2. user clicks edit button
3. data is populated into text boxes
4. user changes data client side
5. user clicks save or cancel
6. if user clicks save send ALL text fields (even if they arent changed) to server
7. run sql update query on data
8. close form
9. if user clicks cancel, do nothing
