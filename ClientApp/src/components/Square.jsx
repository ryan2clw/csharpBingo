import React from 'react';
import styled from 'styled-components';
import PropTypes from 'prop-types';
import { Flex } from 'reflexbox';

import './styles/Square.css';

/**
 * This component is a small number square which makes up a row on a player
 * ticket. The component manages style based on whether or not the 'called' prop
 * is passed down to it.
 * @class
 */
const FlexHeight = styled(Flex)`
  height: ${props => props.height || "54px"};
  background: ${props => props.background || "black"};
`;

class Square extends React.Component {

  width = () => this.props.width || "54px";
  height = () => this.props.height || "54px";
  back = () => this.props.background || "black";
  render() {
    return(
      <FlexHeight background={this.back()} height={this.height()} w={this.width()} p={1} justify='center' align='center' className={'ticket-number ' + (this.props.called ? 'called' : '')}>
          {this.props.ticketNumber}
      </FlexHeight>
    )
  }
}
Square.propTypes = {
  ticketNumber: PropTypes.string,
  called: PropTypes.bool,
};
export default Square;