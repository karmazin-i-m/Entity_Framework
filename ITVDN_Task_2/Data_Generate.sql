USE [ITVDN_Task_2.Models.Footall_DB];  
GO  
ALTER TABLE [Players]
NOCHECK CONSTRAINT [FK_dbo.Players_dbo.Teams_TeamId];  
GO  

INSERT INTO Players([Name],[Position],[Age],[TeamId]) VALUES('Travis Gibbs','ut',48,5),('Kermit Dennis','molestie',35,2),('Dustin Blackwell','tempor',40,5),('Sebastian Harper','nibh.',44,4),('Dalton Duran','commodo',20,4),('Paki Harrington','facilisi.',28,5),('Hammett Knight','mi',23,2),('Mohammad Mcdaniel','auctor',45,2),('Byron Shepard','leo.',37,5),('Price Oconnor','orci',55,2);
INSERT INTO Players([Name],[Position],[Age],[TeamId]) VALUES('Rajah Callahan','Duis',37,5),('Lyle Christensen','purus',38,1),('Samson Nielsen','mus.',48,2),('Calvin Love','magna.',70,5),('Macon Adkins','Maecenas',50,5),('Thaddeus Mccormick','natoque',57,3),('Addison Waller','scelerisque',21,2),('Dominic Suarez','Curabitur',48,3),('Bruno Clarke','faucibus',30,5),('Price Ball','Morbi',66,5);
INSERT INTO Players([Name],[Position],[Age],[TeamId]) VALUES('Yoshio Alexander','Duis',45,1),('Harper Mcgowan','tellus.',64,5),('Galvin Whitaker','neque.',42,4),('Drake Workman','primis',39,3),('Kato Kirkland','eget,',58,1),('Vaughan Fisher','magna,',58,1),('Lucius Christensen','Nullam',64,4),('Camden Forbes','ac,',27,4),('Abdul Simon','vestibulum',68,3),('Erich Maddox','eget,',32,2);
INSERT INTO Players([Name],[Position],[Age],[TeamId]) VALUES('Hyatt Taylor','ultrices.',68,3),('Noble Bryan','ridiculus',48,2),('Kenneth Fletcher','Duis',30,2),('Carter Parker','suscipit,',65,2),('Alvin Langley','molestie',58,5),('Warren Horn','mauris',66,1),('Elijah Young','eu',53,3),('August Hooper','tristique',49,5),('Rashad Head','a',38,1),('Keith Rosario','libero.',41,3);
INSERT INTO Players([Name],[Position],[Age],[TeamId]) VALUES('Matthew Manning','feugiat.',29,2),('Zahir Gill','rhoncus.',69,2),('Armand Salas','in',28,2),('Travis Bishop','turpis',22,3),('Elliott Stein','luctus',32,4),('Dustin Sampson','Nunc',29,2),('Gray Fields','justo',62,1),('Duncan Cotton','nibh',34,1),('Simon Skinner','purus',54,5),('Ethan Walker','Integer',54,1);
INSERT INTO Players([Name],[Position],[Age],[TeamId]) VALUES('Peter Fields','libero.',53,2),('Perry Maxwell','magnis',51,2),('Dieter Meadows','aliquet',27,1),('Denton Briggs','Fusce',31,4),('Caesar Mayo','placerat',45,1),('Emerson Gonzales','Nullam',54,2),('Phillip Fuller','urna,',60,5),('Flynn Pugh','a,',41,2),('Quentin Farmer','egestas.',55,3),('John Downs','eget',32,1);
INSERT INTO Players([Name],[Position],[Age],[TeamId]) VALUES('Aristotle Dean','elit,',48,3),('Akeem Parrish','dictum',48,5),('Orson Wong','malesuada',28,5),('Griffith Schroeder','Quisque',54,1),('Quinn Goodman','Nulla',51,3),('Lucius Buckner','lobortis',37,1),('Ulric Henson','sit',31,4),('Xanthus Robbins','pede',32,5),('Harding Avila','nisi',53,4),('Kasper Joyner','In',25,1);
INSERT INTO Players([Name],[Position],[Age],[TeamId]) VALUES('Lucas Whitfield','dui',36,2),('Brock Kirk','vulputate,',36,4),('Tobias Ferguson','tempor',63,1),('Jacob Griffith','Duis',34,3),('Kibo Tran','risus',34,1),('Gage Levine','lacus.',54,4),('Marshall Solomon','velit',66,3),('Sawyer Nunez','eu',39,1),('Xenos Fitzpatrick','non,',23,4),('Nigel Velez','velit.',70,2);
INSERT INTO Players([Name],[Position],[Age],[TeamId]) VALUES('Dorian Hoover','eros',58,3),('Cyrus Shepherd','Proin',38,3),('Dane Copeland','ultrices',22,2),('Holmes Rasmussen','facilisis',68,3),('Burton Joyner','vel',44,1),('Caldwell Harmon','sed',22,2),('Ishmael Cervantes','adipiscing,',20,1),('Phillip George','Duis',53,5),('Dalton Blanchard','vel',25,3),('Jerry Britt','Ut',50,5);
INSERT INTO Players([Name],[Position],[Age],[TeamId]) VALUES('Hedley Hale','sit',59,5),('Harper Padilla','auctor',58,5),('Mohammad Ratliff','dui',44,5),('Adrian Bean','risus.',63,1),('Barclay Downs','elit,',43,1),('Moses Hull','Morbi',40,5),('Kennedy Bishop','Aenean',33,5),('Graiden Ortega','ipsum',28,4),('Christopher Meyer','dui,',68,5),('Plato Mendoza','lorem',57,4);

USE [ITVDN_Task_2.Models.Footall_DB];  
GO  
ALTER TABLE [Players]
CHECK CONSTRAINT [FK_dbo.Players_dbo.Teams_TeamId];  
GO  

INSERT INTO Teams([Name],[Coach]) VALUES('Ponoka','Tanek Horne'),('South Bend','Vernon Hartman'),('Ham-sur-Sambre','Jerome Valentine'),('Ghlin','Xavier Waters'),('Calgary','Tanner Adams');

DELETE FROM Players
	WHERE [Name] IS NULL
GO

DELETE FROM Teams
	WHERE [Name] IS NULL

USE [ITVDN_Task_2.Models.Footall_DB];
GO
ALTER DATABASE [ITVDN_Task_2.Models.Footall_DB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO

USE [ITVDN_Task_2.Models.Footall_DB];
GO

SELECT  @@Servername AS Server ,
        DB_NAME(database_id) AS DatabaseName ,
        COUNT(database_id) AS Connections ,
        Login_name AS  LoginName ,
        MIN(Login_Time) AS Login_Time ,
        MIN(COALESCE(last_request_end_time, last_request_start_time))
                                                         AS  Last_Batch
FROM    sys.dm_exec_sessions
WHERE   database_id > 0
        AND DB_NAME(database_id) NOT IN ( 'master', 'msdb' )
GROUP BY database_id ,
         login_name
ORDER BY DatabaseName;

SELECT * FROM Players