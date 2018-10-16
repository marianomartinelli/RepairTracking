import React from 'react';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { create, load, remove, update, goToEdit } from '../index';
import List from '../presentational/List';
import Spinner from '../../common/loading/spinner';

class Clients extends React.Component {
    componentWillMount() {
        this.props.load();
    }

    render() {
        if (this.props.loading) {
            return (<Spinner />)
        } else {
            return <List clients={this.props.clients} goToEdit={(id) => this.props.goToEdit(id)} />
        }
    }
}

const mapStateToProps = (state, ownProps) => {
    return ({
        clients: state.client.clients,
        loading: state.client.loading,
    });
};

const mapDispatchToProps = (dispatch, getState) => ({
    ...bindActionCreators({ load, update, remove, goToEdit }, dispatch),
});

export default connect(mapStateToProps, mapDispatchToProps)(Clients);
