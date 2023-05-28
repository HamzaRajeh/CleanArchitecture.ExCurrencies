import  React, { useState,useEffect } from 'react';
 import { TextField } from '@mui/material';
import { CardCurrency } from '../../components/Cards';




export const   FetchCurrencies=()=>{
  
  const [Data,setData]=new useState([])
  const [ShowData,setShowData]=new useState([])
  const FetchCurrenciesData=(PageNumber=1,PageSize=30)=>{
    var requestOptions = {
      method: 'GET',
      redirect: 'follow'
    };
    fetch(`api/GetCurrencies?PageSize=${PageSize}&PageNumber=${PageNumber}`, requestOptions)
      .then(response => response.json())
      .then(result => {
        
        setData([...Data,...result.items])
        setShowData([...result.items]);
     
      })
      .catch(error => console.log('error', error));
    }
  useEffect( ()=>{
    setTimeout(
      FetchCurrenciesData(1,50),1000*1);
 // eslint-disable-next-line
},[])
  return<>
            <div style={{display:"flex",flexDirection:"column",maxHeight:750,overflow:"auto"}} >
 
            <div><h1> Manage your currencies</h1></div>
            <div ><TextField type='text' onChange={(e)=>{
setShowData([... Data.filter(currency => {
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

            }}  size='small'  label="Search" helperText={'Search About Any Data Of currencies '} sm={{ m: 1, width: '50%' }}  sx={{ m: 1, width: '90%' }} /></div>

{ShowData.map((c,index)=>{
return     <CardCurrency  id={c.id} CurrncyCode={c.code} CurrncyName={c.currencyName} />
})}
 </div>
   </>
}
 