const express = require('express');
const cors = require('cors');
const fs = require('fs');

const app = express();
app.use(cors());

app.get('/api/hachiko', (req,res) => {
    let rawdata = fs.readFileSync('hachikoMicroDatabase/hachiko.json');
    let hachiko = JSON.parse(rawdata);
    res.json(hachiko);
});

app.listen('20000', () => console.log("listening on 20000"));