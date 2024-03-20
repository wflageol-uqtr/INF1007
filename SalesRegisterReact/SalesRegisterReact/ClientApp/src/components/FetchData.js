import React, { Component } from 'react';

export class FetchData extends Component {
    static displayName = FetchData.name;

    constructor(props) {
        super(props);
        this.state = { itemLines: [] };
    }

    static renderInvoiceTable(itemLines) {
        let total = 0;
        itemLines.forEach(line => total += line.price);

        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Article</th>
                        <th>Prix</th>
                    </tr>
                </thead>
                <tbody>
                    {itemLines.map(itemLine =>
                        <tr>
                            <td>{itemLine.name}</td>
                            <td>{itemLine.price}</td>
                        </tr>
                    )}
                    <tr>
                        <td><b>Total</b></td>
                        <td><b>{total.toLocaleString()}</b></td>
                    </tr>
                </tbody>
            </table>
        );
    }

    render() {
        return (
            <div>
                <h1 id="tabelLabel" >Facture</h1>
                {FetchData.renderInvoiceTable(this.state.itemLines)}
                <button className="btn btn-primary" onClick={this.scanItem.bind(this)}>Scanner Article</button>
            </div>
        );
    }

    pickRandomId() {
        const ids = [
            '35b7d0f3-58c2-448e-8487-2791cf7ea6a5',
            '22dc5291-607c-4606-9bc1-40bae3f63091',
            'd2344396-8f46-4f3a-bb1e-dec50d52dc1c'
        ];

        return ids[Math.floor(Math.random() * ids.length)];
    }

    async scanItem() {
        let id = this.pickRandomId();

        let response = await fetch(`inventory/searchitem/${id}`);
        let data = await response.json();
        if (data) {
            let newLines = this.state.itemLines.slice();
            newLines.push(data);

            this.setState({ itemLines: newLines })
        }
    }
}
