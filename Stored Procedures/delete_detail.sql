SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-15
-- Description:	Procedure that deletes detail of an invoice
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'delete_detail')
	DROP PROCEDURE delete_detail
GO

CREATE PROCEDURE delete_detail
	@detail_id int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here

	BEGIN TRANSACTION

		DELETE FROM details WITH (ROWLOCK)
		WHERE detail_id = @detail_id

	COMMIT TRANSACTION

	GRANT EXECUTE ON delete_detail TO PUBLIC

END
GO
