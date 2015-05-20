USE [invoices_raman]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-13
-- Description:	Procedure that updates an invoice of a company
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'update_invoice')
	DROP PROCEDURE update_invoice
GO

CREATE PROCEDURE update_invoice
	@invoice_id int,
	@date smalldatetime,
	@company_id int,
	@terms varchar(20)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
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

	IF (@invoice_id IS NULL) BEGIN
		RAISERROR('Error: Invoice ID not found.', 16, 1)
		RETURN -1
	END
	--
	    -- Insert statements for procedure here
	BEGIN TRANSACTION

		UPDATE invoices WITH (ROWLOCK)
		SET terms = @terms, date = @date
		FROM invoices
		WHERE invoices.invoice_id = @invoice_id 

	COMMIT TRANSACTION

	GRANT EXECUTE ON update_invoice TO PUBLIC
END
GO
