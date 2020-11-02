﻿using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new PetaPoco.Database("DefaultConnection");
            var users = db.Query<UserModel>().ToList();
            this.gvUsers.DataSource = users;
            this.gvUsers.DataBind();
        }
    }
}