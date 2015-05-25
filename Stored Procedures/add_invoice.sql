SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-13
-- Description:	Procedure that inserts a new invoice for a company.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'add_invoice')
	DROP PROCEDURE add_invoice
GO

CREATE PROCEDURE add_invoice
	@date smalldatetime,
	@company_id INT,
	@terms VARCHAR(20)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON
	
	-- Insert statements for procedure here
	-- Check if company ID exists
	IF NOT EXISTS (SELECT * FROM companies WHERE company_id = @company_id) BEGIN
		RAISERROR('Company ID does not exist.', 16, 1)
		RETURN -1
	END
	
	-- Check if date is not null
	IF (@date IS NULL) BEGIN
		RAISERROR('Date of invoice cannot be blank. Please enter date.', 16, 1)
		RETURN -1
	END

	-- Check if terms attribute is non-empty
	IF (@terms IS NULL) OR (LTRIM(RTRIM(@terms)) = '') BEGIN
		RAISERROR('Terms of invoice cannot be blank. Please enter terms.', 16, 1)
		RETURN -1
	END

	BEGIN TRANSACTION
		DECLARE @invoice_id INT

		SELECT @invoice_id = isnull(MAX(invoice_id),0) + 1 from invoices

		INSERT INTO invoices (invoice_id, date, company_id, terms) 
		VALUES (@invoice_id, @date, @company_id, @terms);

	COMMIT TRANSACTION

	
	GRANT EXECUTE ON add_invoice TO PUBLIC
	
END
GO
