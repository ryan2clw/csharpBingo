import React from 'react';
import NavMenu from './NavMenu';
import styled from 'styled-components';

const GreyDiv = styled.div`
    background: #d6d2cb center url("Clovers.jpg");;
    height: 900px;
`

export const Layout = (props) => (
    <div>
        <NavMenu />
        <GreyDiv>
            {props.children}
            {/* {console.log("Layout props", props)} */}
        </GreyDiv>
    </div>
);