import React from 'react';
import PropTypes from 'prop-types';
import { Flex } from 'reflexbox';

import './styles/Square.css';

/**
 * This component is a small number square which makes up a row on a player
 * ticket. The component manages style based on whether or not the 'called' prop
 * is passed down to it.
 * @class
 */
class Square extends React.Component {
  render() {
    return(
      <Flex p={1} justify='center' align='center' className={'ticket-number ' + (this.props.called ? 'called' : '')}>
          {this.props.ticketNumber}
      </Flex>
    )
  }
}

Square.propTypes = {
  ticketNumber: PropTypes.string,
  called: PropTypes.bool,
};
export default Square;