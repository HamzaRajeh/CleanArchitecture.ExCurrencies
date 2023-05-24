import React, { useState ,useEffect} from 'react';
  import { TextField } from '@mui/material';
import { CardCurrencyEx } from '../features/components/Cards';

 



export const   Home=()=>{
  
  const [Data,setData]=new useState([])


 
const FetchCurrenciesData=(PageNumber=1,PageSize=30)=>{
  var requestOptions = {
    method: 'GET',
    redirect: 'follow'
  };
  fetch(`https://localhost:5001/api/GetCurrencies?PageSize=${PageSize}&PageNumber=${PageNumber}`, requestOptions)
    .then(response => response.json())
    .then(result => {
      
      setData([...Data,...result.items])
   
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
            <div style={{display:"flex",flexDirection:"column",maxHeight:750,overflow:"auto"}} >
 
            <div><h1>  Exchange currencies</h1></div>
            <div ><TextField type='text'   size='small'  label="Search" helperText={'Search About Any Data Of currencies '}   sx={{ m: 1,width: '65%'}} /></div>

{Data.map((c,index)=>{
return     <CardCurrencyEx  id={c.id} CurrncyName={c.currencyName} CurrncyCode={c.code} Data={[{Titel:"Ex Rajeh",Buy:"510",Sale:"543"},{Titel:"Ex Hamza Rajeh",Buy:"540",Sale:"545"}]} />

})}

 </div>
   </>
}
 
