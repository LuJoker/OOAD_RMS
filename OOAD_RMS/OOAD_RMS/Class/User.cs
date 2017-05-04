﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOAD_RMS
{
    public class User
    {
        private string _account;
        private string _password;
        private string _identity;
        private List<Project> _inProjects = new List<Project>();

        public User()
        {
            Project project1 = new Project();
            project1.ProjectName = "Project1";
            project1.ProjectDescription = "Project1 123";
            Requirement requirement1 = new Requirement();
            requirement1.RequirementName = "Re1";
            requirement1.RequirementDescription = "Re1 123";
            project1.AddRequirement(requirement1);

            Project project2 = new Project();
            project2.ProjectName = "Project2";
            project2.ProjectDescription = "Project2 456";

            Project project3 = new Project();
            project3.ProjectName = "Project3";
            project3.ProjectDescription = "Project3 789";
            Requirement requirement2 = new Requirement();
            requirement2.RequirementName = "Re1";
            requirement2.RequirementDescription = "Re1 123";
            project3.AddRequirement(requirement2);
            Requirement requirement3 = new Requirement();
            requirement3.RequirementName = "Re2";
            requirement3.RequirementDescription = "Re2 456";
            project3.AddRequirement(requirement3);

            _inProjects.Add(project1);
            _inProjects.Add(project2);
            _inProjects.Add(project3);
        } 

        public string UserAccount
        {
            get
            {
                return _account;
            }
            set
            {
                _account = value;
            }
        }

        public string UserPassword
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        
        public string UserIdentity
        {
            get
            {
                return _identity;
            }
            set
            {
                _identity = value;
            }
        }

        public List<Project> GetInProjects()
        {
            return _inProjects;
        }
    }
}
