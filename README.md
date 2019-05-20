#SdWebService.

  This is a project were a school type system was developed.
  We have a normal user that can only access information about himself and an admin that can add users, classes and grades.
  
  This system is working with 4 web services, 2 admin( admin and admin backup) and 2 user (user and userBackup).These webServices are collecting information from external DB connected by SQLServer and presenting the to the user.
  
  The backup versions of the webService were implemented has a mean of error tolerance, if the first DB isn't accessible the WebService will activate the Backups and it will get information from the second DB.
