SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-13
-- Description:	Procedure that deletes a company
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'delete_company')
	DROP PROCEDURE delete_company
GO

CREATE PROCEDURE delete_company
	@company_id int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	-- Ensure invoices are deleted first before deleting the company
	IF EXISTS (SELECT * FROM invoices i, companies c WHERE i.company_id = @company_id) BEGIN
		RAISERROR('Please delete your invoices first before deleting company.', 16, 1)
		RETURN -1
	END

	IF EXISTS (SELECT * FROM addresses a, companies c WHERE a.company_id = @company_id) BEGIN
		RAISERROR('Please delete your addresses first before deleting company.', 16, 1)
		RETURN -1
	END

	BEGIN TRANSACTION
		DELETE FROM companies WITH (ROWLOCK)
		WHERE company_id = @company_id
	COMMIT TRANSACTION

	GRANT EXECUTE ON delete_company TO PUBLIC

END
GO
