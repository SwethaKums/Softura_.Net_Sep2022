import { useState } from "react";
 
const App = () => {
  const [text, setText] = useState("");
  const [error, setError] = useState("");
  const[number,SetNumber]=useState("");
  const [todos, setTodos] = useState([
    { id: 1, item: "swetha" ,cell:"987643424"}
   
  ]);
 
  const removeTodo = (id) => {
    let newTodos = todos.filter((todo) => todo.id !== id);
    setTodos(newTodos);
    // setTodos(todos.filter((todo) => todo.id !== id));
  };
 
  const add = () => {
    if (text.length <= 0) {
      setError("Item cannot be empty");
    } else {
      setTodos([...todos, { id: todos.length + 1, item: text ,cell:number}]);
      setText("");
      setError("");
      SetNumber("");
    }
  };
  return (
    <>
      <h2>Contact Name</h2>
      <div>
        <p>
          <input
            type="text"
            value={text}
            onChange={(e) => {
              setText(e.target.value);
            }}
          />
          <span>{error}</span>
        </p>
        
   
        
      </div>
      <h2>Contact number</h2>
      <div>
        <p>
          <input
            type="number"
            value={number}
            onChange={(e) => {
              SetNumber(e.target.value);
            }}
          />
          <span>{error}</span>
        </p>
        
   
        <button onClick={() => add()}>Add</button>
      </div>
      {todos.length > 0 ? (
        <div>
          <h3>Todo List</h3>
          <div>
            {todos.map((todo) => {
              return (
                <p key={todo.id}>
                  {todo.item}
                  <button onClick={() => removeTodo(todo.id)}>Remove</button>
                </p>
              );
            })}
          </div>
          <div>
            {todos.map((todo) => {
              return (
                <p key={todo.id}>
                  {todo.cell}
                  <button onClick={() => removeTodo(todo.id)}>Remove</button>
                </p>
              );
            })}
          </div>
        </div>
      ) : (
        <p>No Items to show!!!</p>
      )}
    </>
  );
};
 
export default App;