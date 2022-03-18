namespace Employee{
    class Employees{

        public event MethodcallDelegate? ongetid;
        
        public event MethodcallDelegate? ongetname;
       
        public event MethodcallDelegate? ongetdepartmentname;
       
        public Employees(int Id, string name, string departmentName)
        {   
            this.Id = Id;
            this.name = name ;
            this.departmentName = departmentName;
        }

        private int Id;

        public int GetId()
        {   if(ongetid != null ){
              ongetid(this, new EventArgs()) ;
        }
            return Id;
        }

        private string name;

        public string GetName()
        {   if(ongetname != null){
            ongetname(this, new EventArgs()) ;
        }
            return name;
        }

        private string departmentName;

        public string GetDepartmentName()
        {   if(ongetdepartmentname != null) {
            ongetdepartmentname(this, new EventArgs()) ;
                    }
            return departmentName;
        }

        public void employeeUpdate(int Id,string name,string departmentName){
            this.Id = Id ;
            this.name = name ;
            this.departmentName = departmentName ;    
        }

        public void employeeUpdate(string name,int Id,string departmentName){
            this.Id = Id ;
            this.name = name ;
            this.departmentName = departmentName ;
        }

        public void employeeUpdate(string departmentName,string name,int Id){
            this.Id = Id ;
            this.name = name ;
            this.departmentName = departmentName ;
        }

    }

}