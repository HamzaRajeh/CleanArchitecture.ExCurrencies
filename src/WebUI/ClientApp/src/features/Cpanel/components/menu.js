import React from 'react';
import './style/style.css';
import $ from 'jquery'
import * as ObjManageCurrencies  from './Dash';
import { Box, Button } from '@mui/material';
import { Currency } from './Currencies';
 const styleParent={ fontWeight:"900",borderRadius:0,borderBottom:"3px black solid",width:"100%"};
const closeMenu=()=>{
  let menVis=document.getElementsByClassName('visible-menu');
  let es=Array.from(menVis);
  es.map((e)=>{
    const parent=$("#"+e.id).parent();
    parent.css( "border-color", "black" );
    parent.children(['button']).css( "border-color", "black" );
  e.classList.remove("visible-menu");
 e.classList.add("hidden-menu");
  return e;
 })
   }
   const openMenu=(e)=>{
      $(e).removeClass('hidden-menu');
     $(e).addClass('visible-menu');
     const parent=$(e).parent();
     parent.css( "border-color", "blue" );
     parent.children(['button']).css( "border-color", "blue" );
      }
 export const Menu=({onPush})=> {


    return(<>
    <Box>

    <nav id='Grid-Menue'  className="navigation">
    <div className='logo' >
 Ex currencies
</div>
  <ul>
    <li><Button  sx={styleParent} onClick={()=>{
closeMenu();
 openMenu("#ul-1");
 
    }}>Manage Exchange</Button>
    <div id='ul-1' className="submenu hidden-menu">
         <div><Button onClick={()=>onPush(<ObjManageCurrencies.FetchCurrencies/>)} >Currencies</Button></div>
       </div>
       
       </li>
    <li><Button sx={styleParent} onClick={()=>{
 closeMenu();
 openMenu("#ul-2"); 
    }}> Manage currencies</Button>
    <div id='ul-2' className="submenu hidden-menu">
        <div><Button onClick={()=>onPush(<Currency/>)}>Create Currncy </Button></div>
        </div>
    </li>
   </ul>
</nav>
</Box>

    </>)}


