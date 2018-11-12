import React from 'react';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { create, load, remove, update, goToEdit, goToCreate, goToShow } from '../index';
import List from '../presentational/List';
import Spinner from '../../common/loading/spinner';

class Clients extends React.Component {
    componentWillMount() {
        this.props.load();
    }

    render() {
        return <Spinner loading={this.props.loading}>
            <List
                clients={this.props.clients}
                goToEdit={(id) => this.props.goToEdit(id)}
                goToShow={(id) => this.props.goToShow(id)}
                goToCreate={this.props.goToCreate} />
        </Spinner>
    }
}

const mapStateToProps = (state, ownProps) => {
    return ({
        clients: state.client.clients,
        loading: state.client.loading,
    });
};

const mapDispatchToProps = (dispatch, getState) => ({
    ...bindActionCreators({ load, update, remove, goToEdit, goToCreate, goToShow }, dispatch),
});

export default connect(mapStateToProps, mapDispatchToProps)(Clients);
