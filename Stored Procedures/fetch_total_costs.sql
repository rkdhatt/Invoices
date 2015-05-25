SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-21
-- Description:	Procedure that retrieves total costs for each company
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_total_costs')
	DROP PROCEDURE fetch_total_costs
GO

CREATE PROCEDURE fetch_total_costs

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	select t1Result.name, isnull(sum(t2Result.sum_cost), 0) as 'total_cost'
	from (select c.name, i.invoice_id
		from companies c
		left join invoices i
		on c.company_id = i.company_id
	  ) As t1Result

	  full outer join

	  (select i.invoice_id, (quantity * cost) as sum_cost
		from invoices i
		left join details d
		on i.invoice_id = d.invoice_id
	  ) As t2Result
	  on t1Result.invoice_id = t2Result.invoice_id
	group by t1Result.name

	GRANT EXECUTE ON fetch_total_costs TO PUBLIC
	
END
GO
