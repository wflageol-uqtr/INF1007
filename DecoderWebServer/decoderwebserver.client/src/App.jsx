import { useEffect, useState } from 'react';
import './App.css';

function App() {
    const [decoders, setDecoders] = useState();

    useEffect(() => {
        populateDecoders('AAAA000000');
    }, []);

    const contents = decoders === undefined
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
        : <table className="table table-striped" aria-labelledby="tableLabel">
            <thead>
                <tr>
                    <th>Adresse</th>
                    <th>État</th>
                    <th>Dernier redémarrage</th>
                    <th>Dernière réinitialisation</th>
                </tr>
            </thead>
            <tbody>
                {decoders.map(decoder =>
                    <tr>
                        <td>{decoder.address}</td>
                        <td>{decoder.state}</td>
                        <td>{decoder.lastReset}</td>
                        <td>{decoder.lastReinit}</td>
                    </tr>
                )}
            </tbody>
        </table>;

    return (
        <div>
            <h1 id="tableLabel">Liste des décodeurs</h1>
            {contents}
        </div>
    );

    async function populateDecoders(id) {
        var decoders = [];

        for (var i = 1; i <= 12; i++) {
            var address = '127.0.10.' + i;
            const response = await fetch('decoder', {
                method: "POST",
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({
                    id: id,
                    address: address,
                    action: 'info'
                }),
            });
            const data = await response.json();
            data.address = address;

            decoders.push(data);
        }
        setDecoders(decoders);
    }
}

export default App;