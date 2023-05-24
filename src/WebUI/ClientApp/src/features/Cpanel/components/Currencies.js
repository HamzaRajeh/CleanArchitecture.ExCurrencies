import {  Button, Container } from "@mui/material";
import React from "react";
import { HandelSave, InputCurrency } from "../resources/Currencies";
import { FieldsBox } from "../../components/FieldInput";

import './style/login.css'

export const Currency=()=>{



return(
    <Container sx={{mt:10}} component="main" maxWidth="md" >
        <h3> Create Currency </h3>
<FieldsBox  FieldsArray={InputCurrency.CurrencyInfo}>
<Button sx={{marginTop:5,width:"80%"}}  variant="contained"  onClick={HandelSave}>create</Button>
</FieldsBox>
</Container>
);
}

