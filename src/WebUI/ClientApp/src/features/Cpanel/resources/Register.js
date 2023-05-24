
export const InputReqister={
    Register:[
        {col:"AccountDescription",type:"TextField",label:"FullName/Company's Name",defaultValue:"",value:null,class:"",helperText:" Enter Your Company's Name ",ref:null,width:'100%',size:"small"}
        ,{col:"username",type:"TextField",label:"Username",defaultValue:"",value:null,class:"",helperText:" Enter Username ",ref:null,width:'100%',size:"small"}
        ,{col:"Password",type:"PasswordField",label:"Password",defaultValue:null,value:null,class:"success",helperText:" Enter  Password 8 Digit  & complex",ref:null,width:'100%',size:"small"}
        ,{col:"ConfirmPassword",type:"PasswordField",label:"Confirm Password",defaultValue:null,value:null,class:"success",helperText:"Confirm Password ",ref:null,width:'100%',size:"small"}
         ,{col:"Email",type:"EmailField",label:"Email",defaultValue:null,value:null,class:"success",helperText:"Enter your Email ",ref:null,width:'100%',size:"small"}
        ,{col:"Phone",type:"TextField",label:"Phone",defaultValue:null,value:null,class:"success",helperText:"Enter your phone",ref:null,width:'100%',size:"small"}
    ]
}



export const HandelSave=()=>{

    let accountDescription='';
    let Password='';
    let ConfirmPassword='';
    let Email='';
    let username='';
    let Phone='';
    InputReqister.Register.map(a=>{
        switch (a.col) {
            case "AccountDescription":
            accountDescription= a.value
                break;  
                case "username":
                    username= a.value
                        break;          
            case "Password":
            Password= a.value
             break;
             case "ConfirmPassword":
            ConfirmPassword= a.value
                 break;
            case "Email":
            Email= a.value
                     break;  
            case "Phone":
            Phone= a.value
            break;            
            
            default:
                break;
        }


    return null;
    });

 var myHeaders = new Headers();
 myHeaders.append("Content-Type", "application/json");
 
 var raw = JSON.stringify({
   "accountDescription": accountDescription,
   "userName": username,
   "password": Password,
   "confirmPassword":ConfirmPassword,
   "baseCurrencyID":null,
   "email": Email,
   "phoneNumber": Phone
 });
 
 var requestOptions = {
   method: 'POST',
   headers: myHeaders,
   body: raw,
   redirect: 'follow'
 };
 
 fetch("https://localhost:5001/api/CreateUser", requestOptions)
   .then(response => response.json())
   .then(result =>{ console.log(result)
    setTimeout(()=> window.location.href="/Login",500)
})
   .catch(error => console.log('Your Data Invalid Try again,please', error));

}

