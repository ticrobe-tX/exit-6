const express = require('express');
const cors = require('cors');
const fs = require('fs');

const app = express();
app.use(cors());

app.get('/api/pizzas', (req,res) => {
    let rawdata = fs.readFileSync('todayMenu.json');
    let hachiko = JSON.parse(rawdata);
    res.json(hachiko);
});

app.listen('30000', () => console.log("listening on 30000"));