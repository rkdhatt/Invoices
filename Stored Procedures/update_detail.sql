USE [invoices_raman]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-15
-- Description:	Procedure that updates details of an invoice.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'update_detail')
	DROP PROCEDURE update_detail
GO

CREATE PROCEDURE update_detail
	@invoice_id int,
	@detail_id int,
	@description varchar(50),
	@quantity real,
	@cost money
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

		-- Check if terms attribute is non-empty
	IF (@description IS NULL) OR (LTRIM(RTRIM(@description)) = '') BEGIN
		RAISERROR('description of invoice details cannot be blank. Please enter description.', 16, 1)
		RETURN -1
	END

	IF (@quantity IS NULL) OR (@quantity = 0) BEGIN
		RAISERROR('Cannot leave quantity blank/enter 0. Please enter quantity.', 16, 1)
		RETURN -1
	END

	IF (@cost IS NULL) OR (@cost = 0) BEGIN
		RAISERROR('Cannot leave cost blank/enter 0. Please enter cost.', 16, 1)
		RETURN -1
	END

    -- Insert statements for procedure here
	BEGIN TRANSACTION
		UPDATE details WITH (ROWLOCK)
		SET description = @description, quantity = @quantity, cost = @cost
		FROM details
		WHERE details.invoice_id = @invoice_id AND details.detail_id = @detail_id
	COMMIT TRANSACTION

	GRANT EXECUTE ON update_detail TO PUBLIC
END
GO
