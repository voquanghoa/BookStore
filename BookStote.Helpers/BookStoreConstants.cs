﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStote.Helpers
{
    public class BookStoreConstants
    {
        public const string CONFIRM_DIALOG_NAME = "Confirmation";
        public const string MSG_REQUIRED_FIELD = "Please enter the required filed.";

        public const string MSG_EMAIL_INCORRECTED_FORMAT = "Please enter correct email.";

        public const string MSG_PASSWORD_NOT_MATCH = "Password confirm does not match the password.";

        public const string ADMIN_ROLE_TYPE = "ADMIN";

        public const string USER_ROLE_TYPE = "USER";

        public const string MSG_REGISTRY_ERROR = "Error occurred while resgisy user.";

        public const string MSG_REGISTRY_SUCCESS = "Resigtry user sucessfully.";

        public const string MSG_REGISTRY_DUPPLICATED = "Email address is really existing.";

        public const string MSG_CONFIRM_DELETE = "Are you sure to delete this record?";
    }
}