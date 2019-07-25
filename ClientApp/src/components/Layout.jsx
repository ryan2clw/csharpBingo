import React from 'react';
import NavMenu from './NavMenu';
import styled from 'styled-components';

const Body = styled.div`
    background: #076461;
    height: 790px;
`

export const Layout = (props) => (
    <div>
        <NavMenu />
        <Body>
            { props.children }
        </Body>
    </div>
);