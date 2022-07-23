namespace Warehouse.Objects {
    public class Item {
        public int id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public string description { get; set; }
        public int max_per_pallet { get; set; }
        public float price { get; set; }

        public Item() {

        }
    }
}