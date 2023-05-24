
export const InputSignIn={
    SignInAdmin:[
        {col:"username",type:"TextField",label:"Username",defaultValue:"",value:null,class:"",helperText:"Username by defulte is admin",ref:null,width:'100%',size:"small"}
        ,{col:"Password",type:"PasswordField",label:"Password",defaultValue:null,value:null,class:"success",helperText:"Password by defulte is admin",ref:null,width:'100%',size:"small"}
    ]
}
export const SinginAdmin={userName:"admin",Password:"admin",IsAuth:false};
export const HandelSignAdmin=()=>{
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
 a.value=null;

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
        localStorage.setItem('SingInfo',JSON.stringify( result))
        setTimeout(()=> window.location.reload(),1000)
    })
       .catch(error => {alert('error', error)
       localStorage.setItem('SingInfo',JSON.stringify())
    });
    
    }


