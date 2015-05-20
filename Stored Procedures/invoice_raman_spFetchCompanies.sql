SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-12
-- Description:	Procedure that updates an existing company
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_companies')
	DROP PROCEDURE fetch_companies
GO

CREATE PROCEDURE fetch_companies 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	SELECT company_id, name FROM companies;

	GRANT EXECUTE ON fetch_companies TO PUBLIC
	

END
GO
