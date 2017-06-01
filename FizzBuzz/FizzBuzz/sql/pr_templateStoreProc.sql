-- ***********************************************************************
-- Template Stored Procedures
--
-- Use the Specify Values for Template Parameters command (Ctrl-Shift-M) 
-- to fill in the parameter values below. 
-- 
--
--************************************************************************
SET ANSI_PADDING            ON;
SET ANSI_WARNINGS           ON;
SET ARITHABORT              ON;
SET CONCAT_NULL_YIELDS_NULL ON;
SET ANSI_NULLS              ON;
SET QUOTED_IDENTIFIER       ON;
SET NUMERIC_ROUNDABORT      OFF;
GO

SET NOCOUNT ON;
GO

--Create proc if it does not exist
IF (OBJECT_ID(N'[<Schema,,dbo>].[<Procedure_Name,,>]') IS NULL)
BEGIN
  EXEC('CREATE PROCEDURE [<Schema,,dbo>].[<Procedure_Name,,>] AS SET NOCOUNT ON;');
END
GO

--************************************************************************
-- Project / Patch: <Project / Patch,,>
-- Procedure Name:  <Schema,,dbo>.<Procedure_Name,,>
-- Developer:       <Developer,,>
--
-- Description:     <Description,,>
--
-- Version history:
-- <Create Date,datetime,2012-mm-dd> - Created
--************************************************************************
GO

ALTER PROCEDURE [<Schema,,dbo>].[<Procedure_Name,,>] 
AS
BEGIN

  SET NOCOUNT ON;
  --don't delete these variables
  DECLARE 
	  @thisProc NVARCHAR(256) = N'<Schema,,dbo>.<Procedure_Name,,>', --used for error messages
    @tranCount INT = @@TRANCOUNT, --here we check if we are executing inside a tran
    @sysErrMsg VARCHAR(MAX),  -- used to set customised error messages
    @errSev INT, -- error severity
    @errState INT, -- error state
    @errMsg NVARCHAR(MAX); /*this is used to set an explanatory error message BEFORE you call something, 
                                   it is what we previously used to put inside our RAISERROR's*/

  BEGIN TRY
  
    IF(@tranCount = 0) --if we are not executing inside a tran, start one
    BEGIN
      BEGIN TRAN;
    END;
  
    SET @errmsg = N'Explanatory about what we are doing in the following statement(s)';

  
  
    IF(@tranCount = 0 AND XACT_STATE() = 1) --we assume we have started a tran above (it is also checked by the XACT_STATE() function)
    BEGIN  
      COMMIT TRAN;
    END;

    RETURN 0; 
  END TRY

  BEGIN CATCH
    --error handling code
    SELECT @sysErrMsg = ERROR_MESSAGE(), @errSev = ERROR_SEVERITY(), @errState = ERROR_STATE();
  
    IF(@tranCount = 0 AND XACT_STATE() != 0) --we assume we have started a tran above (it is also checked by the XACT_STATE() function)
    BEGIN
      ROLLBACK TRAN;
    END;
  
    --re-raise upstream
    RAISERROR('Error in %s: %s. %s.', @errSev, @errState, @thisProc, @errMsg, @sysErrMsg);
    
    RETURN;
  END CATCH
END;
GO
--end procedure

---- Calling stored procedure to increment the Version number in the database
EXEC dbo.sp_Version @dboObject = '<Schema,,dbo>.<Procedure_Name,,>.PRC', @Version = 1, @ExpectedHash = '';
GO


----uncomment if need to assign execute permissions, 
--GRANT  EXECUTE ON [<Schema,,dbo>].[<Procedure_Name,,>] TO [<Execute_Rights,,PUBLIC>] 
GO