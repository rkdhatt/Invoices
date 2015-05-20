SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-19
-- Description:	Procedure that retreives all companies and their invoices.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_main_report')
	DROP PROCEDURE fetch_main_report
GO

CREATE PROCEDURE fetch_main_report

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	BEGIN TRANSACTION
		SELECT c.company_id, name, date, terms
		FROM companies c
		LEFT JOIN invoices i ON i.company_id = c.company_id

	COMMIT TRANSACTION

	GRANT EXECUTE ON fetch_main_report TO PUBLIC

END
GO
