SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-13
-- Description:	Procedure that retrieves all addresses.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_invoices')
	DROP PROCEDURE fetch_invoices
GO

CREATE PROCEDURE fetch_invoices 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	SELECT * from invoices

	GRANT EXECUTE ON fetch_invoices TO PUBLIC
	
END
GO