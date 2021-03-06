import React from 'react'
import ReactTable from 'react-table';
import columns from './ColumnConfig'
import Toolbar from './Toolbar'
import { Body, Wrapper, Header } from '../../../common/page'
import {Col, Row} from 'reactstrap';

export default props => {

    const { repair: data, title } = props;

    return (
        <Wrapper>
            <Header title={title} />
            <Body>
                <Row>
                    <Toolbar {...props}/>
                </Row>
                    <Col md={{ size: 7, offset: 3 }} style={{marginLeft:"350px"}}>
                        <ReactTable
                            {...props}
                            defaultPageSize={10}
                            className="-striped -highlight"
                            data={data}
                            columns={columns}
                            previousText="Anterior"
                            nextText="Siguiente"
                            showPageSizeOptions= {false}
                            pageText= "Página"
                            ofText= "de"
                            defaultSorted={[
                                {
                                id: "code",
                                asc: true
                                }
                            ]}
                        />
                    </Col>
            </Body>
        </Wrapper>
    )
}
