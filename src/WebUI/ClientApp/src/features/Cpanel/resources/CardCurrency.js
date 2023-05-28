
import authService from '../../../components/api-authorization/AuthorizeService'


export const InputManageCurrency={
    BuySale:[
         {col:"Buy",type:"TextField",label:"Buy",defaultValue:"",value:null,class:"",helperText:"currensy's Buy ",ref:null,width:'40%',size:"small"}
        ,{col:"Sale",type:"TextField",label:"Sale",defaultValue:"",value:null,class:"",helperText:"currensy's Sale ",ref:null,width:'40%',size:"small"}
    ]
}
 

export  const  SetUpdateDashboardHandle =async  (currenciesId) => {
    const token = await authService.getAccessToken();
    const User = await authService.getUser();
 console.log(User)
    let Buy;
    let Sale;
    InputManageCurrency.BuySale.map(a=>{
if(a.col==="Buy")
Buy= a.value
 if(a.col==="Sale")
 Sale= a.value

 a.value=null;
return 0;
});

 var myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");
    myHeaders.append("Authorization",`Bearer ${token}`)
  var raw = JSON.stringify({
   "currenciesId": parseInt(currenciesId),
   "buyRate":parseInt(Buy),
   "saleRate":parseInt(Sale),
   "applicationUserId":  User.id
 });
 
 var requestOptions = {
   method: 'POST',
   headers: myHeaders,
   body: raw,
   redirect: 'follow'
 };
 
 fetch("api/SetUpdateDashboard", requestOptions)
   .then(response => response.json())
   .then(result => {
    console.log(result)
    alert("Updated")
   })
   .catch(error =>console.log('error', error));
     };
    
    export const RejectDashboardHandle=(currenciesId)=>{
 
  
   var myHeaders = new Headers();
   myHeaders.append("Content-Type", "application/json");
   
   var raw = JSON.stringify({
     "currenciesId": parseInt(currenciesId),
     "applicationUserId": ""
   });
   
   var requestOptions = {
     method: 'Delete',
     headers: myHeaders,
     body: raw,
     redirect: 'follow'
   };
   
   fetch("api/RejectExDashboard", requestOptions)
     .then(response => response.text())
     .then(result => {
      console.log(result)
      alert("Updated")
      window.location.href="/"
    })
     .catch(error =>console.log('error', error));
        window.location.href = "/"
      };
 
