using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


//------------------------------------------------------------------------------
// Class Definition for Table/View: DbT_dbo_authors
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbT_dbo_authors : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_au_id = new BasicDAL.DbColumn("[au_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_au_lname = new BasicDAL.DbColumn("[au_lname]", System.Data.DbType.String, false, "LAST");
    private BasicDAL.DbColumn _DbC_au_fname = new BasicDAL.DbColumn("[au_fname]", System.Data.DbType.String, false, "FIRST");
    private BasicDAL.DbColumn _DbC_phone = new BasicDAL.DbColumn("[phone]", System.Data.DbType.String, false, "PHONE");
    private BasicDAL.DbColumn _DbC_address = new BasicDAL.DbColumn("[address]", System.Data.DbType.String, false, "ADDRESS");
    private BasicDAL.DbColumn _DbC_city = new BasicDAL.DbColumn("[city]", System.Data.DbType.String, false, "CITY");
    private BasicDAL.DbColumn _DbC_state = new BasicDAL.DbColumn("[state]", System.Data.DbType.String, false, "ST");
    private BasicDAL.DbColumn _DbC_zip = new BasicDAL.DbColumn("[zip]", System.Data.DbType.String, false, "ZIP");
    private BasicDAL.DbColumn _DbC_contract = new BasicDAL.DbColumn("[contract]", System.Data.DbType.Boolean, false, false);
    private BasicDAL.DbColumn _DbC_email = new BasicDAL.DbColumn("[email]", System.Data.DbType.String, false, "EMAIL");
    
    public BasicDAL.DbColumn DbC_au_id
    {
        get { return _DbC_au_id; }
        set { _DbC_au_id = value; }
    }

    public BasicDAL.DbColumn DbC_au_lname
    {
        get { return _DbC_au_lname; }
        set { _DbC_au_lname = value; }
    }

    public BasicDAL.DbColumn DbC_au_fname
    {
        get { return _DbC_au_fname; }
        set { _DbC_au_fname = value; }
    }

    public BasicDAL.DbColumn DbC_phone
    {
        get { return _DbC_phone; }
        set { _DbC_phone = value; }
    }

    public BasicDAL.DbColumn DbC_address
    {
        get { return _DbC_address; }
        set { _DbC_address = value; }
    }

    public BasicDAL.DbColumn DbC_city
    {
        get { return _DbC_city; }
        set { _DbC_city = value; }
    }

    public BasicDAL.DbColumn DbC_state
    {
        get { return _DbC_state; }
        set { _DbC_state = value; }
    }

    public BasicDAL.DbColumn DbC_zip
    {
        get { return _DbC_zip; }
        set { _DbC_zip = value; }
    }

    public BasicDAL.DbColumn DbC_contract
    {
        get { return _DbC_contract; }
        set { _DbC_contract = value; }
    }

    public BasicDAL.DbColumn DbC_email
    {
        get { return _DbC_email; }
        set { _DbC_email = value; }
    }
    #endregion

    public DbT_dbo_authors()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
        this.DbTableName =  "authors";
    }
}
//------------------------------------------------------------------------------

//------------------------------------------------------------------------------
// Class Definition for Table/View: DbT_dbo_discounts
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbT_dbo_discounts : BasicDAL.DbObject
{

    #region 'DbColumns'

    private BasicDAL.DbColumn _DbC_discount_id = new BasicDAL.DbColumn("[discount_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_discounttype = new BasicDAL.DbColumn("[discounttype]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_stor_id = new BasicDAL.DbColumn("[stor_id]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_lowqty = new BasicDAL.DbColumn("[lowqty]", System.Data.DbType.Int16, false, 0);
    private BasicDAL.DbColumn _DbC_highqty = new BasicDAL.DbColumn("[highqty]", System.Data.DbType.Int16, false, 0);
    private BasicDAL.DbColumn _DbC_discount = new BasicDAL.DbColumn("[discount]", System.Data.DbType.Decimal, false, 0);
  
    public BasicDAL.DbColumn DbC_discount_id
    {
        get { return _DbC_discount_id; }
        set { _DbC_discount_id = value; }
    }

    public BasicDAL.DbColumn DbC_discounttype
    {
        get { return _DbC_discounttype; }
        set { _DbC_discounttype = value; }
    }

    public BasicDAL.DbColumn DbC_stor_id
    {
        get { return _DbC_stor_id; }
        set { _DbC_stor_id = value; }
    }

    public BasicDAL.DbColumn DbC_lowqty
    {
        get { return _DbC_lowqty; }
        set { _DbC_lowqty = value; }
    }

    public BasicDAL.DbColumn DbC_highqty
    {
        get { return _DbC_highqty; }
        set { _DbC_highqty = value; }
    }

    public BasicDAL.DbColumn DbC_discount
    {
        get { return _DbC_discount; }
        set { _DbC_discount = value; }
    }

  
    #endregion

    public DbT_dbo_discounts()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
        this.DbTableName = "dbo.discounts";
        
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbT_dbo_employee
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbT_dbo_employee : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_emp_id = new BasicDAL.DbColumn("[emp_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_fname = new BasicDAL.DbColumn("[fname]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_minit = new BasicDAL.DbColumn("[minit]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_lname = new BasicDAL.DbColumn("[lname]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_job_id = new BasicDAL.DbColumn("[job_id]", System.Data.DbType.Int16, false, 0);
    private BasicDAL.DbColumn _DbC_job_lvl = new BasicDAL.DbColumn("[job_lvl]", System.Data.DbType.Byte, false, 0);
    private BasicDAL.DbColumn _DbC_pub_id = new BasicDAL.DbColumn("[pub_id]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_hire_date = new BasicDAL.DbColumn("[hire_date]", System.Data.DbType.DateTime, false, DateTime.Today );
    private BasicDAL.DbColumn _DbC_email = new BasicDAL.DbColumn("[email]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_phone = new BasicDAL.DbColumn("[phone]", System.Data.DbType.String, false, "");

    public BasicDAL.DbColumn DbC_emp_id
    {
        get { return _DbC_emp_id; }
        set { _DbC_emp_id = value; }
    }

    public BasicDAL.DbColumn DbC_fname
    {
        get { return _DbC_fname; }
        set { _DbC_fname = value; }
    }

    public BasicDAL.DbColumn DbC_minit
    {
        get { return _DbC_minit; }
        set { _DbC_minit = value; }
    }

    public BasicDAL.DbColumn DbC_lname
    {
        get { return _DbC_lname; }
        set { _DbC_lname = value; }
    }

    public BasicDAL.DbColumn DbC_job_id
    {
        get { return _DbC_job_id; }
        set { _DbC_job_id = value; }
    }

    public BasicDAL.DbColumn DbC_job_lvl
    {
        get { return _DbC_job_lvl; }
        set { _DbC_job_lvl = value; }
    }

    public BasicDAL.DbColumn DbC_pub_id
    {
        get { return _DbC_pub_id; }
        set { _DbC_pub_id = value; }
    }

    public BasicDAL.DbColumn DbC_hire_date
    {
        get { return _DbC_hire_date; }
        set { _DbC_hire_date = value; }
    }

    public BasicDAL.DbColumn DbC_phone
    {
        get { return _DbC_phone; }
        set { _DbC_phone = value; }
    }
    public BasicDAL.DbColumn DbC_email
    {
        get { return _DbC_email; }
        set { _DbC_email = value; }
    }

    #endregion

    public DbT_dbo_employee()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
        this.DbTableName = "dbo.employee";
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbT_dbo_jobs
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbT_dbo_jobs : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_job_id = new BasicDAL.DbColumn("[job_id]", System.Data.DbType.Int16, true, 0);
    private BasicDAL.DbColumn _DbC_job_desc = new BasicDAL.DbColumn("[job_desc]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_min_lvl = new BasicDAL.DbColumn("[min_lvl]", System.Data.DbType.Byte, false, 0);
    private BasicDAL.DbColumn _DbC_max_lvl = new BasicDAL.DbColumn("[max_lvl]", System.Data.DbType.Byte, false, 0);

    public BasicDAL.DbColumn DbC_job_id
    {
        get { return _DbC_job_id; }
        set { _DbC_job_id = value; }
    }

    public BasicDAL.DbColumn DbC_job_desc
    {
        get { return _DbC_job_desc; }
        set { _DbC_job_desc = value; }
    }

    public BasicDAL.DbColumn DbC_min_lvl
    {
        get { return _DbC_min_lvl; }
        set { _DbC_min_lvl = value; }
    }

    public BasicDAL.DbColumn DbC_max_lvl
    {
        get { return _DbC_max_lvl; }
        set { _DbC_max_lvl = value; }
    }

    #endregion

    public DbT_dbo_jobs()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
        this.DbTableName = "dbo.jobs";
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbT_dbo_pub_info
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbT_dbo_pub_info : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_pub_id = new BasicDAL.DbColumn("[pub_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_logo = new BasicDAL.DbColumn("[logo]", System.Data.DbType.Binary, false,null);
    private BasicDAL.DbColumn _DbC_pr_info = new BasicDAL.DbColumn("[pr_info]", System.Data.DbType.String, false, "");

    public BasicDAL.DbColumn DbC_pub_id
    {
        get { return _DbC_pub_id; }
        set { _DbC_pub_id = value; }
    }

    public BasicDAL.DbColumn DbC_logo
    {
        get { return _DbC_logo; }
        set { _DbC_logo = value; }
    }

    public BasicDAL.DbColumn DbC_pr_info
    {
        get { return _DbC_pr_info; }
        set { _DbC_pr_info = value; }
    }

    #endregion

    public DbT_dbo_pub_info()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
        this.DbTableName = "dbo.pub_info";
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbT_dbo_publishers
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbT_dbo_publishers : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_pub_id = new BasicDAL.DbColumn("[pub_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_pub_name = new BasicDAL.DbColumn("[pub_name]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_city = new BasicDAL.DbColumn("[city]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_state = new BasicDAL.DbColumn("[state]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_country = new BasicDAL.DbColumn("[country]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_email = new BasicDAL.DbColumn("[email]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_phone = new BasicDAL.DbColumn("[phone]", System.Data.DbType.String, false, "");

    public BasicDAL.DbColumn DbC_pub_id
    {
        get { return _DbC_pub_id; }
        set { _DbC_pub_id = value; }
    }

    public BasicDAL.DbColumn DbC_pub_name
    {
        get { return _DbC_pub_name; }
        set { _DbC_pub_name = value; }
    }

    public BasicDAL.DbColumn DbC_city
    {
        get { return _DbC_city; }
        set { _DbC_city = value; }
    }

    public BasicDAL.DbColumn DbC_state
    {
        get { return _DbC_state; }
        set { _DbC_state = value; }
    }

    public BasicDAL.DbColumn DbC_country
    {
        get { return _DbC_country; }
        set { _DbC_country = value; }
    }
    public BasicDAL.DbColumn DbC_email
    {
        get { return _DbC_email; }
        set { _DbC_email = value; }
    }

    public BasicDAL.DbColumn DbC_phone
    {
        get { return _DbC_phone; }
        set { _DbC_phone = value; }
    }
    #endregion

    public DbT_dbo_publishers()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
        this.DbTableName = "dbo.publishers";
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbT_dbo_roysched
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbT_dbo_roysched : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_title_id = new BasicDAL.DbColumn("[title_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_lorange = new BasicDAL.DbColumn("[lorange]", System.Data.DbType.Int32, true, 0);
    private BasicDAL.DbColumn _DbC_hirange = new BasicDAL.DbColumn("[hirange]", System.Data.DbType.Int32, true, 0);
    private BasicDAL.DbColumn _DbC_royalty = new BasicDAL.DbColumn("[royalty]", System.Data.DbType.Int32, false, 0);

    public BasicDAL.DbColumn DbC_title_id
    {
        get { return _DbC_title_id; }
        set { _DbC_title_id = value; }
    }

    public BasicDAL.DbColumn DbC_lorange
    {
        get { return _DbC_lorange; }
        set { _DbC_lorange = value; }
    }

    public BasicDAL.DbColumn DbC_hirange
    {
        get { return _DbC_hirange; }
        set { _DbC_hirange = value; }
    }

    public BasicDAL.DbColumn DbC_royalty
    {
        get { return _DbC_royalty; }
        set { _DbC_royalty = value; }
    }

    #endregion

    public DbT_dbo_roysched()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
        this.DbTableName = "dbo.roysched";
    }
}


//------------------------------------------------------------------------------
// Class Definition for Table/View: DbT_dbo_salesmaster
// Date   :11/03/2022
// Author :
//------------------------------------------------------------------------------
public class DbT_dbo_salesmaster : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_ord_num = new BasicDAL.DbColumn("[ord_num]", System.Data.DbType.Int32, true, 0);
    private BasicDAL.DbColumn _DbC_stor_id = new BasicDAL.DbColumn("[stor_id]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_ord_date = new BasicDAL.DbColumn("[ord_date]", System.Data.DbType.DateTime, false, DateTime.Today);
    private BasicDAL.DbColumn _DbC_payterms = new BasicDAL.DbColumn("[payterms]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_stor_ord_num = new BasicDAL.DbColumn("[stor_ord_num]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_stor_ord_date = new BasicDAL.DbColumn("[stor_ord_date]", System.Data.DbType.DateTime, false, DateTime.Today);

    public BasicDAL.DbColumn DbC_ord_num
    {
        get { return _DbC_ord_num; }
        set { _DbC_ord_num = value; }
    }

    public BasicDAL.DbColumn DbC_stor_id
    {
        get { return _DbC_stor_id; }
        set { _DbC_stor_id = value; }
    }

    public BasicDAL.DbColumn DbC_ord_date
    {
        get { return _DbC_ord_date; }
        set { _DbC_ord_date = value; }
    }

    public BasicDAL.DbColumn DbC_payterms
    {
        get { return _DbC_payterms; }
        set { _DbC_payterms = value; }
    }

    public BasicDAL.DbColumn DbC_stor_ord_num
    {
        get { return _DbC_stor_ord_num; }
        set { _DbC_stor_ord_num = value; }
    }

    public BasicDAL.DbColumn DbC_stor_ord_date
    {
        get { return _DbC_stor_ord_date; }
        set { _DbC_stor_ord_date = value; }
    }

    #endregion

    public DbT_dbo_salesmaster()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
        this.DbTableName = "dbo.salesmaster";
    }
}
//------------------------------------------------------------------------------

//------------------------------------------------------------------------------
// Class Definition for Table/View: DbT_dbo_salesdetails
// Date   :11/03/2022
// Author :
//------------------------------------------------------------------------------
public class DbT_dbo_salesdetails : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_ord_num = new BasicDAL.DbColumn("[ord_num]", System.Data.DbType.Int32, true, 0);
    private BasicDAL.DbColumn _DbC_title_id = new BasicDAL.DbColumn("[title_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_qty = new BasicDAL.DbColumn("[qty]", System.Data.DbType.Int16, false, 0);
    private BasicDAL.DbColumn _DbC_price = new BasicDAL.DbColumn("[price]", System.Data.DbType.Decimal, false, 0);

    public BasicDAL.DbColumn DbC_ord_num
    {
        get { return _DbC_ord_num; }
        set { _DbC_ord_num = value; }
    }

    public BasicDAL.DbColumn DbC_title_id
    {
        get { return _DbC_title_id; }
        set { _DbC_title_id = value; }
    }

    public BasicDAL.DbColumn DbC_qty
    {
        get { return _DbC_qty; }
        set { _DbC_qty = value; }
    }

    public BasicDAL.DbColumn DbC_price
    {
        get { return _DbC_price; }
        set { _DbC_price = value; }
    }

    #endregion

    public DbT_dbo_salesdetails()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
        this.DbTableName = "dbo.salesdetails";
    }
}
//------------------------------------------------------------------------------


//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbT_dbo_stores
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbT_dbo_stores : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_stor_id = new BasicDAL.DbColumn("[stor_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_stor_name = new BasicDAL.DbColumn("[stor_name]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_stor_address = new BasicDAL.DbColumn("[stor_address]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_city = new BasicDAL.DbColumn("[city]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_state = new BasicDAL.DbColumn("[state]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_zip = new BasicDAL.DbColumn("[zip]", System.Data.DbType.String, false, "");

    public BasicDAL.DbColumn DbC_stor_id
    {
        get { return _DbC_stor_id; }
        set { _DbC_stor_id = value; }
    }

    public BasicDAL.DbColumn DbC_stor_name
    {
        get { return _DbC_stor_name; }
        set { _DbC_stor_name = value; }
    }

    public BasicDAL.DbColumn DbC_stor_address
    {
        get { return _DbC_stor_address; }
        set { _DbC_stor_address = value; }
    }

    public BasicDAL.DbColumn DbC_city
    {
        get { return _DbC_city; }
        set { _DbC_city = value; }
    }

    public BasicDAL.DbColumn DbC_state
    {
        get { return _DbC_state; }
        set { _DbC_state = value; }
    }

    public BasicDAL.DbColumn DbC_zip
    {
        get { return _DbC_zip; }
        set { _DbC_zip = value; }
    }

    #endregion

    public DbT_dbo_stores()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
        this.DbTableName = "dbo.stores";
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbT_dbo_titleauthor
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbT_dbo_titleauthor : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_au_id = new BasicDAL.DbColumn("[au_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_title_id = new BasicDAL.DbColumn("[title_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_au_ord = new BasicDAL.DbColumn("[au_ord]", System.Data.DbType.Byte, false, 0);
    private BasicDAL.DbColumn _DbC_royaltyper = new BasicDAL.DbColumn("[royaltyper]", System.Data.DbType.Int32, false, 0);

    public BasicDAL.DbColumn DbC_au_id
    {
        get { return _DbC_au_id; }
        set { _DbC_au_id = value; }
    }

    public BasicDAL.DbColumn DbC_title_id
    {
        get { return _DbC_title_id; }
        set { _DbC_title_id = value; }
    }

    public BasicDAL.DbColumn DbC_au_ord
    {
        get { return _DbC_au_ord; }
        set { _DbC_au_ord = value; }
    }

    public BasicDAL.DbColumn DbC_royaltyper
    {
        get { return _DbC_royaltyper; }
        set { _DbC_royaltyper = value; }
    }

    #endregion

    public DbT_dbo_titleauthor()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
        this.DbTableName = "dbo.titleauthor";
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbT_dbo_titles
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbT_dbo_titles : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_title_id = new BasicDAL.DbColumn("[title_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_title = new BasicDAL.DbColumn("[title]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_type = new BasicDAL.DbColumn("[type]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_pub_id = new BasicDAL.DbColumn("[pub_id]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_price = new BasicDAL.DbColumn("[price]", System.Data.DbType.Decimal, false, 0);
    private BasicDAL.DbColumn _DbC_advance = new BasicDAL.DbColumn("[advance]", System.Data.DbType.Decimal, false, 0);
    private BasicDAL.DbColumn _DbC_royalty = new BasicDAL.DbColumn("[royalty]", System.Data.DbType.Int32, false, 0);
    private BasicDAL.DbColumn _DbC_ytd_sales = new BasicDAL.DbColumn("[ytd_sales]", System.Data.DbType.Int32, false, 0);
    private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[notes]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_pubdate = new BasicDAL.DbColumn("[pubdate]", System.Data.DbType.DateTime, false, DateTime.Today);

    public BasicDAL.DbColumn DbC_title_id
    {
        get { return _DbC_title_id; }
        set { _DbC_title_id = value; }
    }

    public BasicDAL.DbColumn DbC_title
    {
        get { return _DbC_title; }
        set { _DbC_title = value; }
    }

    public BasicDAL.DbColumn DbC_type
    {
        get { return _DbC_type; }
        set { _DbC_type = value; }
    }

    public BasicDAL.DbColumn DbC_pub_id
    {
        get { return _DbC_pub_id; }
        set { _DbC_pub_id = value; }
    }

    public BasicDAL.DbColumn DbC_price
    {
        get { return _DbC_price; }
        set { _DbC_price = value; }
    }

    public BasicDAL.DbColumn DbC_advance
    {
        get { return _DbC_advance; }
        set { _DbC_advance = value; }
    }

    public BasicDAL.DbColumn DbC_royalty
    {
        get { return _DbC_royalty; }
        set { _DbC_royalty = value; }
    }

    public BasicDAL.DbColumn DbC_ytd_sales
    {
        get { return _DbC_ytd_sales; }
        set { _DbC_ytd_sales = value; }
    }

    public BasicDAL.DbColumn DbC_notes
    {
        get { return _DbC_notes; }
        set { _DbC_notes = value; }
    }

    public BasicDAL.DbColumn DbC_pubdate
    {
        get { return _DbC_pubdate; }
        set { _DbC_pubdate = value; }
    }

    #endregion

    public DbT_dbo_titles()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
        this.DbTableName = "dbo.titles";
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbV_dbo_titleview
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbV_dbo_titleview : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_title = new BasicDAL.DbColumn("[title]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_au_ord = new BasicDAL.DbColumn("[au_ord]", System.Data.DbType.Byte, false, 0);
    private BasicDAL.DbColumn _DbC_au_lname = new BasicDAL.DbColumn("[au_lname]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_price = new BasicDAL.DbColumn("[price]", System.Data.DbType.Decimal, false, 0);
    private BasicDAL.DbColumn _DbC_ytd_sales = new BasicDAL.DbColumn("[ytd_sales]", System.Data.DbType.Int32, false, 0);
    private BasicDAL.DbColumn _DbC_pub_id = new BasicDAL.DbColumn("[pub_id]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_au_id = new BasicDAL.DbColumn("[au_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_title_id = new BasicDAL.DbColumn("[title_id]", System.Data.DbType.String, true, "");
  

    public BasicDAL.DbColumn DbC_title
    {
        get { return _DbC_title; }
        set { _DbC_title = value; }
    }

    public BasicDAL.DbColumn DbC_au_ord
    {
        get { return _DbC_au_ord; }
        set { _DbC_au_ord = value; }
    }

    public BasicDAL.DbColumn DbC_au_lname
    {
        get { return _DbC_au_lname; }
        set { _DbC_au_lname = value; }
    }

    public BasicDAL.DbColumn DbC_price
    {
        get { return _DbC_price; }
        set { _DbC_price = value; }
    }

    public BasicDAL.DbColumn DbC_ytd_sales
    {
        get { return _DbC_ytd_sales; }
        set { _DbC_ytd_sales = value; }
    }

    public BasicDAL.DbColumn DbC_pub_id
    {
        get { return _DbC_pub_id; }
        set { _DbC_pub_id = value; }
    }

    public BasicDAL.DbColumn DbC_au_id
    {
        get { return _DbC_au_id; }
        set { _DbC_au_id = value; }
    }

    public BasicDAL.DbColumn DbC_title_id
    {
        get { return _DbC_title_id; }
        set { _DbC_title_id = value; }
    }



    #endregion

    public DbV_dbo_titleview()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.View;
        this.DbTableName = "dbo.titleview";
 
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbSP_dbo_byroyalty
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbSP_dbo_byroyalty : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_au_id = new BasicDAL.DbColumn("[au_id]", System.Data.DbType.String, false, "");

    public BasicDAL.DbColumn DbC_au_id
    {
        get { return _DbC_au_id; }
        set { _DbC_au_id = value; }
    }

    #endregion
    #region 'DbParameters'
    public BasicDAL.DbParameter sp_return_value = new BasicDAL.DbParameter("@RETURN_VALUE", System.Data.DbType.Int32, System.Data.ParameterDirection.ReturnValue, 0);
    public BasicDAL.DbParameter sp_percentage = new BasicDAL.DbParameter("@percentage", System.Data.DbType.Int32, System.Data.ParameterDirection.Input, 0);
    #endregion

    public DbSP_dbo_byroyalty()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.StoredProcedure;
        this.DbStoredProcedureName = "dbo.byroyalty";
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbSP_dbo_reptq1
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbSP_dbo_reptq1 : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_pub_id = new BasicDAL.DbColumn("[pub_id]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_avg_price = new BasicDAL.DbColumn("[avg_price]", System.Data.DbType.Decimal, false, 0);

    public BasicDAL.DbColumn DbC_pub_id
    {
        get { return _DbC_pub_id; }
        set { _DbC_pub_id = value; }
    }

    public BasicDAL.DbColumn DbC_avg_price
    {
        get { return _DbC_avg_price; }
        set { _DbC_avg_price = value; }
    }

    #endregion
    #region 'DbParameters'
    public BasicDAL.DbParameter sp_return_value = new BasicDAL.DbParameter("@RETURN_VALUE", System.Data.DbType.Int32, System.Data.ParameterDirection.ReturnValue, 0);
    #endregion

    public DbSP_dbo_reptq1()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.StoredProcedure;
        this.DbStoredProcedureName = "dbo.reptq1";
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbSP_dbo_reptq2
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbSP_dbo_reptq2 : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_type = new BasicDAL.DbColumn("[type]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_pub_id = new BasicDAL.DbColumn("[pub_id]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_avg_ytd_sales = new BasicDAL.DbColumn("[avg_ytd_sales]", System.Data.DbType.Int32, false, 0);

    public BasicDAL.DbColumn DbC_type
    {
        get { return _DbC_type; }
        set { _DbC_type = value; }
    }

    public BasicDAL.DbColumn DbC_pub_id
    {
        get { return _DbC_pub_id; }
        set { _DbC_pub_id = value; }
    }

    public BasicDAL.DbColumn DbC_avg_ytd_sales
    {
        get { return _DbC_avg_ytd_sales; }
        set { _DbC_avg_ytd_sales = value; }
    }

    #endregion
    #region 'DbParameters'
    public BasicDAL.DbParameter sp_return_value = new BasicDAL.DbParameter("@RETURN_VALUE", System.Data.DbType.Int32, System.Data.ParameterDirection.ReturnValue, 0);
    #endregion

    public DbSP_dbo_reptq2()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.StoredProcedure;
        this.DbStoredProcedureName = "dbo.reptq2";
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbSP_dbo_reptq3
// Date   :19/02/2022
// Author :
//------------------------------------------------------------------------------
public class DbSP_dbo_reptq3 : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_pub_id = new BasicDAL.DbColumn("[pub_id]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_type = new BasicDAL.DbColumn("[type]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_cnt = new BasicDAL.DbColumn("[cnt]", System.Data.DbType.Int32, false, 0);

    public BasicDAL.DbColumn DbC_pub_id
    {
        get { return _DbC_pub_id; }
        set { _DbC_pub_id = value; }
    }

    public BasicDAL.DbColumn DbC_type
    {
        get { return _DbC_type; }
        set { _DbC_type = value; }
    }

    public BasicDAL.DbColumn DbC_cnt
    {
        get { return _DbC_cnt; }
        set { _DbC_cnt = value; }
    }

    #endregion
    #region 'DbParameters'
    public BasicDAL.DbParameter sp_return_value = new BasicDAL.DbParameter("@RETURN_VALUE", System.Data.DbType.Int32, System.Data.ParameterDirection.ReturnValue, 0);
    public BasicDAL.DbParameter sp_lolimit = new BasicDAL.DbParameter("@lolimit", System.Data.DbType.Currency, System.Data.ParameterDirection.Input, 0);
    public BasicDAL.DbParameter sp_hilimit = new BasicDAL.DbParameter("@hilimit", System.Data.DbType.Currency, System.Data.ParameterDirection.Input, 0);
    public BasicDAL.DbParameter sp_type = new BasicDAL.DbParameter("@type", System.Data.DbType.AnsiStringFixedLength, System.Data.ParameterDirection.Input, 12);
    #endregion

    public DbSP_dbo_reptq3()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.StoredProcedure;
        this.DbStoredProcedureName = "dbo.reptq3";
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbV_dbo_titles_publishers
// Date   :09/03/2022
// Author :
//------------------------------------------------------------------------------
public class DbV_dbo_titles_publishers : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_title_id = new BasicDAL.DbColumn("[title_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_title = new BasicDAL.DbColumn("[title]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_pub_id = new BasicDAL.DbColumn("[pub_id]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_pub_name = new BasicDAL.DbColumn("[pub_name]", System.Data.DbType.String, false, "");
    

    public BasicDAL.DbColumn DbC_title_id
    {
        get { return _DbC_title_id; }
        set { _DbC_title_id = value; }
    }

    public BasicDAL.DbColumn DbC_title
    {
        get { return _DbC_title; }
        set { _DbC_title = value; }
    }

    public BasicDAL.DbColumn DbC_pub_id
    {
        get { return _DbC_pub_id; }
        set { _DbC_pub_id = value; }
    }

    public BasicDAL.DbColumn DbC_pub_name
    {
        get { return _DbC_pub_name; }
        set { _DbC_pub_name = value; }
    }

    
    #endregion

    public DbV_dbo_titles_publishers()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.View;
        this.DbTableName = "dbo.titles_publishers";
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbV_dbo_AuthorsFullname
// Date   :11/03/2022
// Author :
//------------------------------------------------------------------------------
public class DbV_dbo_AuthorsFullname : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_au_id = new BasicDAL.DbColumn("[au_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_au_lname = new BasicDAL.DbColumn("[au_lname]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_au_fname = new BasicDAL.DbColumn("[au_fname]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_phone = new BasicDAL.DbColumn("[phone]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_address = new BasicDAL.DbColumn("[address]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_city = new BasicDAL.DbColumn("[city]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_state = new BasicDAL.DbColumn("[state]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_zip = new BasicDAL.DbColumn("[zip]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_contract = new BasicDAL.DbColumn("[contract]", System.Data.DbType.Boolean, false, false);
    private BasicDAL.DbColumn _DbC_email = new BasicDAL.DbColumn("[email]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_au_fullname = new BasicDAL.DbColumn("[au_fullname]", System.Data.DbType.String, false, "");

    public BasicDAL.DbColumn DbC_au_id
    {
        get { return _DbC_au_id; }
        set { _DbC_au_id = value; }
    }

    public BasicDAL.DbColumn DbC_au_lname
    {
        get { return _DbC_au_lname; }
        set { _DbC_au_lname = value; }
    }

    public BasicDAL.DbColumn DbC_au_fname
    {
        get { return _DbC_au_fname; }
        set { _DbC_au_fname = value; }
    }

    public BasicDAL.DbColumn DbC_phone
    {
        get { return _DbC_phone; }
        set { _DbC_phone = value; }
    }

    public BasicDAL.DbColumn DbC_address
    {
        get { return _DbC_address; }
        set { _DbC_address = value; }
    }

    public BasicDAL.DbColumn DbC_city
    {
        get { return _DbC_city; }
        set { _DbC_city = value; }
    }

    public BasicDAL.DbColumn DbC_state
    {
        get { return _DbC_state; }
        set { _DbC_state = value; }
    }

    public BasicDAL.DbColumn DbC_zip
    {
        get { return _DbC_zip; }
        set { _DbC_zip = value; }
    }

    public BasicDAL.DbColumn DbC_contract
    {
        get { return _DbC_contract; }
        set { _DbC_contract = value; }
    }

    public BasicDAL.DbColumn DbC_email
    {
        get { return _DbC_email; }
        set { _DbC_email = value; }
    }

    public BasicDAL.DbColumn DbC_au_fullname
    {
        get { return _DbC_au_fullname; }
        set { _DbC_au_fullname = value; }
    }

    #endregion

    public DbV_dbo_AuthorsFullname()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.View;
        this.DbTableName = "dbo.AuthorsFullname";
    }
}
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// Class Definition for Table/View: DbV_dbo_pub_info_publisher
// Date   :12/03/2022
// Author :
//------------------------------------------------------------------------------
public class DbV_dbo_pub_info_publisher : BasicDAL.DbObject
{

    #region 'DbColumns'
    private BasicDAL.DbColumn _DbC_pub_id = new BasicDAL.DbColumn("[pub_id]", System.Data.DbType.String, true, "");
    private BasicDAL.DbColumn _DbC_pr_info = new BasicDAL.DbColumn("[pr_info]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_logo = new BasicDAL.DbColumn("[logo]", System.Data.DbType.Binary , false,null);
    private BasicDAL.DbColumn _DbC_pub_name = new BasicDAL.DbColumn("[pub_name]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_city = new BasicDAL.DbColumn("[city]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_state = new BasicDAL.DbColumn("[state]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_country = new BasicDAL.DbColumn("[country]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_phone = new BasicDAL.DbColumn("[phone]", System.Data.DbType.String, false, "");
    private BasicDAL.DbColumn _DbC_email = new BasicDAL.DbColumn("[email]", System.Data.DbType.String, false, "");
 
    public BasicDAL.DbColumn DbC_pub_id
    {
        get { return _DbC_pub_id; }
        set { _DbC_pub_id = value; }
    }

    public BasicDAL.DbColumn DbC_pr_info
    {
        get { return _DbC_pr_info; }
        set { _DbC_pr_info = value; }
    }

    public BasicDAL.DbColumn DbC_logo
    {
        get { return _DbC_logo; }
        set { _DbC_logo = value; }
    }

    public BasicDAL.DbColumn DbC_pub_name
    {
        get { return _DbC_pub_name; }
        set { _DbC_pub_name = value; }
    }

    public BasicDAL.DbColumn DbC_city
    {
        get { return _DbC_city; }
        set { _DbC_city = value; }
    }

    public BasicDAL.DbColumn DbC_state
    {
        get { return _DbC_state; }
        set { _DbC_state = value; }
    }

    public BasicDAL.DbColumn DbC_country
    {
        get { return _DbC_country; }
        set { _DbC_country = value; }
    }

    public BasicDAL.DbColumn DbC_phone
    {
        get { return _DbC_phone; }
        set { _DbC_phone = value; }
    }

    public BasicDAL.DbColumn DbC_email
    {
        get { return _DbC_email; }
        set { _DbC_email = value; }
    }


    #endregion

    public DbV_dbo_pub_info_publisher()
    {
        this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
        this.DbObjectType = BasicDAL.DbObjectTypeEnum.View;
        this.DbTableName = "dbo.pub_info_publisher";
    }
}
//------------------------------------------------------------------------------
