import {  Button, Container } from "@mui/material";
import React from "react";
import { HandelSave, InputReqister } from "../resources/Register";
import { FieldsBox } from "../../components/FieldInput";

import './style/login.css'

export const Reqister=()=>{



return(
    <Container sx={{mt:10}} component="main" maxWidth="xs" >
        <h3> Reqister </h3>
<FieldsBox  FieldsArray={InputReqister.Register}>

<Button sx={{marginTop:5,width:"80%"}}  variant="contained"  onClick={HandelSave}>Register</Button>
</FieldsBox>


</Container>
);
}

