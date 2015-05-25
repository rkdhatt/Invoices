SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-19
-- Description:	Procedure that retreives invoice and detail information 
--              for the company report based on company ID.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_company_report')
	DROP PROCEDURE fetch_company_report
GO

CREATE PROCEDURE fetch_company_report
	-- Add the parameters for the stored procedure here
	@company_id int = 1

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	IF (@company_id IS NULL) BEGIN
		RAISERROR('Error: Company ID does not exist.', 16, 1)
		RETURN -1
	END
    -- Insert statements for procedure here
	BEGIN TRANSACTION

		select name, date, terms, description, '$'+ CONVERT(money, quantity * cost) as 'total_cost'
		from companies c, invoices i, details d
		where c.company_id =i.company_id and d.invoice_id = i.invoice_id and c.company_id = @company_id

	COMMIT TRANSACTION

	GRANT EXECUTE ON fetch_company_report TO PUBLIC
END
GO
