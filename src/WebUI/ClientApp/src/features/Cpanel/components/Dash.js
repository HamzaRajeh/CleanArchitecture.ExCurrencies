import  React, { useState,useEffect } from 'react';
 import { TextField } from '@mui/material';
import { CardCurrency } from '../../components/Cards';




export const   FetchCurrencies=()=>{
  
  const [Data,setData]=new useState([])
  const [ShowData,setShowData]=new useState([])


  const [IsFirst,setIsFirst]=new useState(true);

  
  const FetchCurrenciesData=(PageNumber=1,PageSize=30)=>{
    var requestOptions = {
      method: 'GET',
      redirect: 'follow'
    };
    fetch(`https://localhost:5001/api/GetCurrencies?PageSize=${PageSize}&PageNumber=${PageNumber}`, requestOptions)
      .then(response => response.json())
      .then(result => {
        
        setData([...Data,...result.items])
      if (IsFirst)
      {

        setShowData([...result.items]);
        setIsFirst(false);
      }
      })
      .catch(error => console.log('error', error));
    }
  useEffect( ()=>{
      FetchCurrenciesData(1,50);
 // eslint-disable-next-line
},[])
  return<>
            <div style={{display:"flex",flexDirection:"column",maxHeight:750,overflow:"auto"}} >
 
            <div><h1> Manage your currencies</h1></div>
            <div ><TextField type='text' onChange={(e)=>{
              if(!e.currentTarget.value )
              {
                setShowData([...Data])

              }else
              setShowData([...Data.filter(a=>a.text===e.currentTarget.value ||a.id===e.currentTarget.value || a.author_id===e.currentTarget.value || a.created_at===e.currentTarget.value )])


            }} size='small'  label="Search" helperText={'Search About Any Data Of currencies '} sm={{ m: 1, width: '50%' }}  sx={{ m: 1, width: '90%' }} /></div>

{ShowData.map((c,index)=>{
return     <CardCurrency  id={c.id} CurrncyCode={c.code} CurrncyName={c.currencyName} />
})}
 </div>
   </>
}
 