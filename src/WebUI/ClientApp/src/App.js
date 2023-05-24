import React from 'react';
  import   {Cpanel}   from './features/Cpanel/Cpanel';
import {  Routes,Route,   NavLink } from 'react-router-dom';
import './App.css';
import {Box, Switch } from '@mui/material';
 import { Reqister } from './features/Cpanel/components/Register';
import { SignInOfAdmin } from './features/Cpanel/components/SignIn';
import { Home } from './components/Home';

 

function App() {
   return (
    <div  className="App">
      <div>
<Switch  checked={localStorage.getItem('modeTheme')==="dark"?true:false}  color="default"  onChange={(e)=>{
if(e.currentTarget.checked)
localStorage.setItem('modeTheme','dark');
else{
  localStorage.setItem('modeTheme','light');
}
window.location.reload();
          }} />
</div>
<Box   className="App-header"      >
        <div className='App-logo-div '> 
        <b  className="App-logo"> EX</b>
           </div>
          <nav className="sidebar">
          <NavLink  className='App-link' to={'/Cpanel'}>Cpanel</NavLink>
          <NavLink  className='App-link' to={'/register'}>Register</NavLink>
          <NavLink  className='App-link' to={'/Login'}>Login</NavLink>
          </nav>

    
        
       </Box>
<Routes>
<Route path="/" element={<Home/>} />
<Route path="/Cpanel" element={<Cpanel/>} />
<Route path="/Register" element={<Reqister/>} />
<Route path="/Login" element={<SignInOfAdmin/>} />
 
</Routes>
 
 
    </div>
  );
}

export default App;
