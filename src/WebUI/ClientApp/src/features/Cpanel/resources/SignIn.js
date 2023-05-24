
export const InputSignIn={
    SignInAdmin:[
        {col:"username",type:"TextField",label:"Username",defaultValue:"",value:null,class:"",helperText:"Username by defulte is admin",ref:null,width:'100%',size:"small"}
        ,{col:"Password",type:"PasswordField",label:"Password",defaultValue:null,value:null,class:"success",helperText:"Password by defulte is admin",ref:null,width:'100%',size:"small"}
    ]
}
export const SinginAdmin={userName:"admin",Password:"admin",IsAuth:false};
export function HandelSignAdmin(){
        let Password='';
        let username='';
        InputSignIn.SignInAdmin.map(a=>{
            switch (a.col) {
                    case "username":
                        username= a.value
                            break;          
                case "Password":
                Password= a.value
                 break;
               
                default:
                    break;
            }

    return null;
        
        });
    
     var myHeaders = new Headers();
     myHeaders.append("Content-Type", "application/json");
     
     var raw = JSON.stringify({
       "userName": username,
       "password": Password
     });
     
     var requestOptions = {
       method: 'POST',
       headers: myHeaders,
       body: raw,
       redirect: 'follow'
     };
     
     fetch("https://localhost:5001/api/Login", requestOptions)
       .then(response => response.json())
       .then(result =>{ console.log(result)
        if(!localStorage.getItem('SingInfo'))
        localStorage.setItem('SingInfo',JSON.stringify(result))
        setTimeout(()=> window.location.href="/Cpanel",1000)
      }    )
       .catch(error => {console.log('error', error)
       
    });
    
    }


