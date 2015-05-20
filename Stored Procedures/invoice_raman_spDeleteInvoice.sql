SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-14
-- Description:	Procedure that deletes an invoice
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'delete_invoice')
	DROP PROCEDURE delete_invoice
GO

CREATE PROCEDURE delete_invoice
	@invoice_id int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	
	-- Need to check if invoices has details first.
	IF EXISTS (SELECT * FROM details WHERE details.invoice_id = @invoice_id) BEGIN
		RAISERROR('Please delete invoice details first before deleting this invoice.', 16, 1)
		RETURN -1
	END 

	BEGIN TRANSACTION

		DELETE FROM invoices WITH (ROWLOCK)
		WHERE invoice_id = @invoice_id

	COMMIT TRANSACTION

	GRANT EXECUTE ON delete_invoice TO PUBLIC

END
GO
