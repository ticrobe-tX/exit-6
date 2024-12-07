import os
from flask import Flask, json, jsonify
from flask_cors import CORS

app = Flask(__name__)
CORS(app)

@app.route('/orders', methods=['GET'])
def orders():
    absolutePath = os.path.realpath(os.path.dirname(__file__))
    url = os.path.join(absolutePath, "ordersMicroDatabase/orders.json")
    orderList = json.load(open(url))
    return jsonify(orderList)