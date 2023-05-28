import React, { useState ,useEffect} from 'react';
  import { TextField } from '@mui/material';
import { CardCurrencyEx } from '../features/components/Cards';

 



export const   Home=()=>{
  
  const [Data,setData]=new useState([])
  const [Result,setResult]=new useState([])


 
const FetchCurrenciesData=(PageNumber=1,PageSize=10)=>{
  var requestOptions = {
    method: 'GET',
    redirect: 'follow'
  };
  fetch(`https://localhost:5001/api/GetCurrencies?PageSize=${PageSize}&PageNumber=${PageNumber}`, requestOptions)
    .then(response => response.json())
    .then(result => {
      
      setData([...Data,...result.items])
      setResult([...Data,...result.items])
   
    })
    .catch(error => console.log('error', error));
  }
useEffect( ()=>{
    FetchCurrenciesData(1,50);
// eslint-disable-next-line
},[])
  
   React.useEffect( ()=>{
      FetchCurrenciesData();
 // eslint-disable-next-line
},[])
  return<>
            <div style={{display:"flex",flexDirection:"column",maxHeight:"100%",overflow:"auto",justifySelf:'center',alignItems:'center'}} >
 
            <div><h1>  Exchange currencies</h1></div>
            <div ><TextField type='text'   size='small'  label="Search" helperText={'Search About Any Data Of currencies '} onChange={(e)=>{
setResult([... Data.filter(currency => {
  let query=e.currentTarget.value;
  if (query=== "") {
    //if query is empty
    return currency;
  } else if (currency.currencyName.toLowerCase().includes(query.toLowerCase())) {
    //returns filtered array
    return currency;
  }
  else if (currency.code.toLowerCase().includes(query.toLowerCase())) {
    //returns filtered array
    return currency;
  }
  else{
    return null;
  }
})]);

            }}    sx={{ m: 1}} /></div>

{Result.map((c,index)=>{
return     <CardCurrencyEx  id={c.id} CurrncyName={c.currencyName} CurrncyCode={c.code}  />

})}

 </div>
   </>
}
 
