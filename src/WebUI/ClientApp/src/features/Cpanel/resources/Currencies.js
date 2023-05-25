
export const InputCurrency={
    CurrencyInfo:[
        {col:"currencyName",type:"TextField",label:"currency's name",defaultValue:"",value:null,class:"",helperText:" Enter  currency's name ",ref:null,width:'40%',size:"small"}
        ,{col:"currencyNameAr",type:"TextField",label:"currency's name ar",defaultValue:"",value:null,class:"",helperText:" Enter  currency's name ar",ref:null,width:'40%',size:"small"}
        ,{col:"code",type:"TextField",label:"currency's code",defaultValue:"",value:null,class:"",helperText:"currensy's code ",ref:null,width:'40%',size:"small"}
        ,{col:"symbol",type:"TextField",label:"symbol's code",defaultValue:"",value:null,class:"",helperText:"currensy's symbol ",ref:null,width:'40%',size:"small"}
        ,{col:"country",type:"TextField",label:"country's  ",defaultValue:"",value:null,class:"",helperText:"currensy's country ",ref:null,width:'80%',size:"small"}

    ]
}
export const HandelSave=()=>{
    let currencyName='';
    let currencyNameAr='';
    let symbol='';
    let code='';
    let country='';
    InputCurrency.CurrencyInfo.map(a=>{
        switch (a.col) {
            case "currencyName":
                currencyName=a.value
        break;
        case "currencyNameAr":
            currencyNameAr=a.value
        break;
        case "symbol":
            symbol=a.value
        break;
        case "code":
            code=a.value
         break;
         case "country":
            country=a.value
         break;
            default:
                break;
        }
return null;

    })
    var myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");
    var raw = JSON.stringify({
      "country": country,
      "currencyName": currencyName,
      "currencyNameAr": currencyNameAr,
      "code": code,
      "symbol": symbol
    });
    
    var requestOptions = {
      method: 'POST',
      headers: myHeaders,
      body: raw,
      redirect: 'follow'
    };
    
    fetch("https://localhost:5001/api/PostCurrencies", requestOptions)
      .then(response => response.json())
      .then(result =>{ console.log(result)
        alert("Created")
    window.location.reload();
    })
      .catch(error =>   window.location.reload());

}