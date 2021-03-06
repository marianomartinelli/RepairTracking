import React from 'react';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import Spinner from '../../common/loading/spinner';
import Update from '../presentational/Update';
import { update, goToClients } from '../index'

class Clients extends React.Component {
    render() {
        const { selectedClient, update, goToClients, loading } = this.props;
        return <Spinner loading={loading}>
            <Update
                initialValues={selectedClient}
                onSubmit={values => update(values)}
                cancel={goToClients} />
        </Spinner>
    }
}

const mapStateToProps = (state) => ({
    selectedClient: state.client.selectedClient,
    loading: state.client.loading
});

const mapDispatchToProps = (dispatch) => bindActionCreators({ update, goToClients }, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(Clients);