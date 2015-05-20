SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-20
-- Description:	Procedure that retrieves number of invoices per company.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_num_invoices')
	DROP PROCEDURE fetch_num_invoices
GO

CREATE PROCEDURE fetch_num_invoices 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	select all name, count(invoice_id) as sum_invoices
	from companies c
	left join invoices i
	on c.company_id = i.company_id
	group by name

	GRANT EXECUTE ON fetch_num_invoices TO PUBLIC
	
END
GO
