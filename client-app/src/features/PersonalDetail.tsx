import { Link } from "react-router-dom";
import { Input } from "semantic-ui-react";

export default function PersonalDetail() {
  return (
    <div className="Bamboo-personaldeatil">
      <div className="Bamboo-pd-card-1">Hi</div>

      <div className="Bamboo-pd-card-2">
        <div className="Bamboo-pd-card-content">
            <div>
                <img alt="logo" src="../assets/back-arrow.svg"/>
            </div>
          <div>
            <h1>Personal Details</h1>
            <p>Lets begin with necessary information</p>
          </div>

          <div className="form-group">
            <label>Enter mobile number linked with aadhar</label>
            <br />
            <Input className="input-form-mobile" type="text" placeholder="mobile number" />
          </div>

          <div className="form-group">
            <label>Registered/ Personal e-mail address</label>
            <br />
            <Input className="input-form-email" type="email" placeholder="e-mail" />
          </div>

          <div className="form-group">
            <label>PAN (Personal Account number)</label>
            <br />
            <Input className="input-form-pan" type="text" placeholder="PAN number" />
          </div>

          <div className="form-group-checkbox">
          <input className="input-box" type="checkbox"/>
          <span>&nbsp; &nbsp; I agree with <Link to='/terms'>Terms and Condition</Link></span>
          </div>

          <div className="submit-input">
            <button className="input-button">
                submit
            </button>
          </div>
        </div>
      </div>
    </div>
  );
}



  