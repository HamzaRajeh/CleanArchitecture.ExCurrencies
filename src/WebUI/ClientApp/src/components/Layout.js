import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from './NavMenu';
import {Box, Switch } from '@mui/material';

export class Layout extends Component {
  static displayName = Layout.name;

  render() {
    return (
      <div>
        <Switch  checked={localStorage.getItem('modeTheme')==="dark"?true:false}  color="default"  onChange={(e)=>{
if(e.currentTarget.checked)
localStorage.setItem('modeTheme','dark');
else{
  localStorage.setItem('modeTheme','light');
}
window.location.reload();
          }} />
          <Box >
         <NavMenu />
        <Container tag="main">
          {this.props.children}
        </Container>
            </Box>
      </div>
      
    );
  }
}
