SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-13
-- Description:	Procedure that updates an existing address of a company.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'update_address')
	DROP PROCEDURE update_address
GO

CREATE PROCEDURE update_address
	-- Add the parameters for the stored procedure here
	@company_id int,
	@address_id int,
	@addresses varchar(100),
	@phone varchar(13),
	@date_modify smalldatetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	IF NOT EXISTS (SELECT company_id FROM addresses where company_id = @company_id) BEGIN
		RAISERROR('Company doesn''t exist...', 16, 1)
		RETURN -1
	END

    -- Insert statements for procedure here
	BEGIN
		BEGIN TRANSACTION
			UPDATE addresses WITH (ROWLOCK)
			SET addresses = @addresses, phone = @phone, date_modify = @date_modify
			WHERE company_id = @company_id AND address_id = @address_id
		COMMIT TRANSACTION
	END

	GRANT EXECUTE ON update_address TO PUBLIC

END
GO
