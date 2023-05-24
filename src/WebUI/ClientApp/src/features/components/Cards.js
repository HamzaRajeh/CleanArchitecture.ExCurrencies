import React, { useEffect, useState } from "react";
import './style/Card.css'
//  import $ from 'jquery';
import { Button } from "@mui/material";
import { FieldsBox } from "./FieldInput";
import { InputManageCurrency , RejectDashboardHandle, SetUpdateDashboardHandle} from "../Cpanel/resources/CardCurrency";
 
export const  CardCurrency=({id,CurrncyCode='',CurrncyName='',btnContect={recive:'',cancel:'Reject',view:'Set/update'}})=>{


    return(
        <>
        <div className="Card" style={{zIndex:id+2}}>
           <div className="Card-Header">
<span className="Card-CurrncyName">{CurrncyName}</span>
<span className="Card-CurrncyName">{CurrncyCode}</span>
           </div>
           <div id={"Currency"+id} className="Card-body">
           <FieldsBox sx={{}} FieldsArray={InputManageCurrency.BuySale}>
</FieldsBox>
</div>
         <div className="Card-footer">
<Button >{btnContect.recive}</Button>
<Button onClick={()=>{
RejectDashboardHandle(id);

}} >{btnContect.cancel}</Button>
 <Button  onClick={()=>{
 SetUpdateDashboardHandle(id)
}}>{btnContect.view}</Button>
 </div>  
  
</div>
        
        </>
    )
}
 
export const  CardCurrencyEx=({id,CurrncyCode='',CurrncyName=''})=>{
const [Data,setData]=new useState([])
function fetchData(CurrencyId) {
    var myHeaders = new Headers();
    myHeaders.append("accept", "application/json");
    
    var requestOptions = {
      method: 'GET',
      headers: myHeaders,
      redirect: 'follow'
    };
    
    fetch(`https://localhost:5001/api/GetDashboardQuerByIdCurrency?CurrenciesId=${CurrencyId}`, requestOptions)
      .then(response => response.json())
      .then(result => {console.log(result.items)
        setData(result.items)
    })
      .catch(error => console.log('error', error));
}
useEffect(()=>{
    fetchData(id);
    console.log(Data);
    // eslint-disable-next-line
},[])
    return(
        <>
        <div className="Card" style={{zIndex:id+2}}>
           <div className="Card-Header">
<span className="Card-CurrncyName">{CurrncyName}</span>
<span className="Card-CurrncyName">{CurrncyCode}</span>
           </div>
           <div id={"Currency"+id} className="Card-body">
           <div className="Record-ex">
            <div className="Record-Titel">{"Compny Id"}</div>
            <div className="Record-Buy">{"Buy"}</div>
            <div className="Record-Sale">{"Sale"}</div>
                </div>
           {
           
Data.map((ex)=>{
return <>
<div className="Record-ex" >
<div className="Record-Titel">{ex.applicationUserId}</div>
<div className="Record-Buy">{ex.buyRate}</div>
<div className="Record-Sale">{ex.saleRate}</div>
    </div></>

})

           }
</div>
         <div className="Card-footer">
 
 </div>  
  
</div>
        
        </>
    )
}
 