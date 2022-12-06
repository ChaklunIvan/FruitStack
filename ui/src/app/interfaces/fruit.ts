export interface Fruit{
  name: string;
  id: number;
  family: string;
  genus: string;
  order: string;
  nutrition: {
    carbohydrates: number;
    protein: number;
    fat: number;
    calories: number;
    sugar: number
  }
}
