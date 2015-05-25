USE [invoices_raman]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-15
-- Description:	Procedure that inserts a new detail for an invoice.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'add_detail')
	DROP PROCEDURE add_detail
GO

CREATE PROCEDURE add_detail
	@invoice_id int,
	@description varchar(50),
	@quantity real,
	@cost money
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON
	
	-- Insert statements for procedure here
	-- Check if any attributes are empty
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

	BEGIN TRANSACTION
		DECLARE @detail_id INT
		SELECT @detail_id = isnull(MAX(detail_id),0) + 1 from details

		INSERT INTO details (invoice_id, detail_id, description, quantity, cost)
		VALUES (@invoice_id, @detail_id, @description, @quantity, @cost);
	COMMIT TRANSACTION

	
	GRANT EXECUTE ON add_detail TO PUBLIC
	
END
