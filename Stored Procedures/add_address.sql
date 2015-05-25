SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-12
-- Description:	Procedure that adds an address of a company
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'add_address')
	DROP PROCEDURE add_address
GO

CREATE PROCEDURE add_address 
	-- Add the parameters for the stored procedure here
	@addresses varchar(100),
	@company_id int,
	@phone varchar(13),
	@date_modify smalldatetime
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

	-- Check if addresses attribute is non-empty
	IF (@addresses IS NULL) OR (LTRIM(RTRIM(@addresses)) = '') BEGIN
		RAISERROR('Addresses cannot be blank. Please enter addresses.', 16, 1)
		RETURN -1
	END

	-- Check if address is unique
	IF EXISTS (SELECT * FROM addresses ad WHERE LOWER(ad.addresses) = LOWER(@addresses)) BEGIN
		RAISERROR('Address already exists. Please enter a unique address.', 16, 1)
		RETURN -1
	END

		-- Check if date_modify attribute is non-empty
	IF (@date_modify IS NULL) BEGIN
		RAISERROR('Date cannot be blank. Please enter date.', 16, 1)
		RETURN -1
	END

	BEGIN TRANSACTION

	-- Create ID within transaction to stay atomic
	DECLARE @address_id INT
	SELECT @address_id = isnull(MAX(address_id),0) + 1 from addresses

	INSERT INTO addresses (company_id, address_id, addresses, phone, date_modify) 
	VALUES (@company_id, @address_id, @addresses, @phone, @date_modify)

	COMMIT TRANSACTION

	GRANT EXECUTE ON add_address TO PUBLIC

END
GO
