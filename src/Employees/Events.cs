namespace Employee{

        public delegate void MethodcallDelegate(object sender,EventArgs args) ;
        
        class Events {
        internal static void ongetid(object sender , EventArgs args){
        Console.Write("getId() called,");
    }
        internal static void ongetname(object sender , EventArgs args){
        Console.Write("getName() called,");
    }
        internal static void ongetdepartmentname(object sender , EventArgs args){
        Console.Write("getDepartmentName() called,");
    }
        }
        
    
}